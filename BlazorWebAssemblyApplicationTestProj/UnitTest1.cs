using Bunit;
using TestingBlazorBUnit.Pages;

namespace BlazorWebAssemblyApplicationTestProj
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void CounterShouldIncrementWhenClicked()
        {
            var cut1 = RenderComponent<Counter>();
            cut1.Find("button").Click(); // finds the first button in the counter page
            cut1.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
        [Fact]
        public void CounterShouldIncrementByValueWhenClicked()
        {
            var cut1 = RenderComponent<Counter>(parameters => parameters.Add(p=>p.value,2));
            cut1.Find("button").Click(); // finds the first button in the counter page and clicks it automatically
            cut1.Find("p").MarkupMatches("<p role=\"status\">Current count: 2</p>");
        }
        [Fact]
        public void RenderParticularWord()
        {
            var cut2 = RenderComponent<MyPage>();
            cut2.Find("input").Change("My Bro");
            cut2.Find("h1").MarkupMatches("<h1>You entered My Bro</h1>");
        }
    }
}