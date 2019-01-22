using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    class FindingsAggregator : IEnumerable<string>
    {

        private List<SearchFinding> m_AllFindings;

        public FindingsAggregator()
        {
            m_AllFindings = new List<SearchFinding>();
        }

        public void ClearFindings ()
        {
            m_AllFindings.Clear();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (SearchFinding finding in m_AllFindings)
            {
                yield return finding.Text;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddFinding(string i_Text, SearchFinding.TypeEnum i_Type)
        {
            m_AllFindings.Add(new SearchFinding(i_Text, i_Type));
        }

        public IEnumerable EventsFindings
        {
            get { return FindingsSource(SearchFinding.TypeEnum.Event); }
        }

        public IEnumerable GroupsFindings
        {
            get { return FindingsSource(SearchFinding.TypeEnum.Group); }
        }

        public IEnumerable PagesFindings
        {
            get { return FindingsSource(SearchFinding.TypeEnum.Page); }
        }

        public IEnumerable PostsFindings
        {
            get { return FindingsSource(SearchFinding.TypeEnum.Post); }
        }

        private IEnumerable<string> FindingsSource(SearchFinding.TypeEnum i_Type)
        {
            foreach (SearchFinding finding in m_AllFindings)
            {
                if (finding.Type == i_Type)
                {
                    yield return finding.Text;
                }
            }
        }
    }
}
