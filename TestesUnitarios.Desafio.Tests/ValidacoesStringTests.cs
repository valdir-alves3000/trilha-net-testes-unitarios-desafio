using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        string texto = "Matrix";
        int resultadoEsperado = 6;

        // Act
        int resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData("Esse é um texto qualquer")]
    [InlineData("Em qualquer situação, é importante manter a calma e a compostura.")]
    [InlineData("Você pode escolher qualquer sabor de sorvete que preferir na sorveteria.")]
    [InlineData("Não há qualquer dúvida de que ele é um dos melhores jogadores da equipe.")]
    public void DeveContemAPalavraQualquerNoTexto(string texto)
    {
        // Arrange
        string textoProcurado = "qualquer";

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        string texto = "Esse é um texto qualquer";
        string textoProcurado = "teste";

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        string texto = "Começo, meio e fim do texto procurado";
        string textoProcurado = "procurado";

        // Act
        bool resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("oterroc átse arogA", "Agora está correto")]
    [InlineData("2024", "4202")]
    public void DeveInverterOTexto(string texto, string resultadoEsperado)
    {
        // Act
        string resultado = _validacoes.InverterTexto(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
