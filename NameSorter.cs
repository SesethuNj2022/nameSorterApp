
namespace nameSorterApp
{
    public class NameSorter
    {
        private readonly List<string> _names;

        public NameSorter(List<string> names)
        {
            _names = names ?? throw new ArgumentNullException(nameof(names));
        }

        public void Sort()
        {
            _names.Sort((name1, name2) =>
            {
                var nameParts1 = name1.Split(' ');
                var nameParts2 = name2.Split(' ');

                var lastNameComparison = string.Compare(nameParts1.Last(), nameParts2.Last(), StringComparison.Ordinal);
                if (lastNameComparison != 0)
                    return lastNameComparison;

                for (int i = 0; i < Math.Min(nameParts1.Length - 1, nameParts2.Length - 1); i++)
                {
                    var givenNameComparison = string.Compare(nameParts1[i], nameParts2[i], StringComparison.Ordinal);
                    if (givenNameComparison != 0)
                        return givenNameComparison;
                }

                return nameParts2.Length.CompareTo(nameParts1.Length);
            });
        }

        public void DisplaySortedNames()
        {
            foreach (var name in _names)
            {
                Console.WriteLine(name);
            }
        }

        public void WriteToFile(string filePath)
        {
            File.WriteAllLines(filePath, _names);
        }
    }
}
