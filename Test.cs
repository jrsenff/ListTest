using System.Collections;

namespace ListTest
{
    public class Test : IEnumerable
    {
        public string StudentName { get; set; }
        public string TestNumber { get; set; }

        public override string ToString()
        {
            return StudentName.ToString() + ", " + TestNumber.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return StudentName.GetEnumerator();
        }
    }
}
