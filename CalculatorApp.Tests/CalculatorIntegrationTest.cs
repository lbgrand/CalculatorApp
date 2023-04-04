using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class CalculatorIntegrationTest 
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public CalculatorIntegrationTest(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("/")]
    public async Task shouldLoadTheMainPageOfApp(string url)
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();
        Assert.Equal("text/html; charset=utf-8", 
            response.Content.Headers.ContentType.ToString());
    }

    [Theory]
    [InlineData("/api")]
    public async Task apisForArithmeticalOperationsShouldWork(string url)
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync(url + "/sum/5.6/6.98");

        response.EnsureSuccessStatusCode();
        Assert.Contains("12.58", await response.Content.ReadAsStringAsync());
    }
}