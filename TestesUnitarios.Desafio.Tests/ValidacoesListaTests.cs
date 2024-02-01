using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        List<int> resultadoEsperado = new List<int> { 5, 9 };

        // Act
        List<int> resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int numeroParaProcurar = 9;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int numeroParaProcurar = 10;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        List<int> lista = new List<int> { 5, 7, 8, 9 };
        List<int> resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        int multiplicador = 2;
        
        // Act
        List<int> resultado = _validacoes.MultiplicarNumerosLista(lista, multiplicador);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int resultadoEsperado = 9;

        // Act
        int resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(new int[] { 5, -1, -8, 9 }, -8)]
    [InlineData(new int[] { 1, -2, 7, 11 }, -2)]
    [InlineData(new int[] { 6, -2, 7, -11 }, -11)]
    public void DeveRetornarOMenorNumeroDaLista(int[] array, int resultadoEsperado)
    {
        // Arrange
        List<int> lista = new List<int>(array);

        // // Act
        int resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
