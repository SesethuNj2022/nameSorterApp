using NUnit.Framework;
using System.Collections.Generic;

namespace nameSorterApp.Test
{
    [TestFixture]
    public class NameSorterTests
    {
        [Test]
        public void Sort_ShouldSortNamesCorrectly()
        {
            var names = new List<string>
            {
                "Janet Parsons",
                "Vaugh Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter"
            };
            var expectedSortedNames = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaugh Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            var nameSorter = new NameSorter(names);

            nameSorter.Sort();

            Assert.Equals(expectedSortedNames, names);
        }
    }
}
