using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Calculator.Tests
{
    [Binding]
    public class CalculatorSteps
    {
        private MyCalculator target;

        [BeforeScenario]
        public void BeforeScenario()
        {
            target = new MyCalculator();
        }

        [Given(@"輸入第一個數字 ""(.*)""")]
        public void 假設輸入第一個數字(int first)
        {
            //arrange
            ScenarioContext.Current.Set<int>(first, "first");
        }
        
        [Given(@"輸入第二個數字 ""(.*)""")]
        public void 假設輸入第二個數字(int second)
        {
            //arrange
            ScenarioContext.Current.Set<int>(second, "second");
        }
        
        [When(@"計算時")]
        public void 當計算時()
        {
            //act
            var first = ScenarioContext.Current.Get<int>("first");
            var second = ScenarioContext.Current.Get<int>("second");

            var actual = target.Add(first, second);
            ScenarioContext.Current.Set<int>(actual, "result");
        }
        
        [Then(@"結果是 ""(.*)""")]
        public void 那麼結果是(int expected)
        {
            //assert
            var actual = ScenarioContext.Current.Get<int>("result");

            Assert.AreEqual(expected, actual);
        }
    }
}
