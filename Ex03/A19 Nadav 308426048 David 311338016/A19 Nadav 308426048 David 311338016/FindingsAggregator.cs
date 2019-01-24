using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    public class FindingsAggregator : IEnumerable<string>
    {
        private List<string> m_AllFindings;

        public FindingsAggregator()
        {
            m_AllFindings = new List<string>();
        }

        public void ClearFindings()
        {
            m_AllFindings.Clear();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string finding in m_AllFindings)
            {
                yield return finding;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddFinding(string i_Text)
        {
            m_AllFindings.Add(i_Text);
        }
    }
}
