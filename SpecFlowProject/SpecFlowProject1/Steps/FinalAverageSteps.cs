using Calculos.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class FinalAverageSteps
    {
        Estudiante estudiante = new Estudiante();
        double total;
        double note1;
        double note2;
        double note3;

        [Given(@"first note is (.*)")]
        public void GivenFirstNoteIs(double note1)
        {
            this.note1 = note1;
        }

        [Given(@"second note is (.*)")]
        public void GivenSecondNoteIs(double note2)
        {
            this.note2 = note2;
        }

        [Given(@"third note is (.*)")]
        public void GivenThirdNoteIs(double note3)
        {
            this.note3 = note3;
        }

        [When(@"the notes are averaged")]
        public void WhenTheNotesAreAveraged()
        {
            total = estudiante.promedioFinal(note1, note2, note3);
        }

        [Then(@"average total (.*)")]
        public void ThenAverageTotal(double result)
        {
            Assert.AreEqual(total, result);
        }
    }
}
