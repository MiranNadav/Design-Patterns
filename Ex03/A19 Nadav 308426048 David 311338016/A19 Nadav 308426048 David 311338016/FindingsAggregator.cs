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

        private List<string> m_AllFindings;

        public FindingsAggregator()
        {
            m_AllFindings = new List<string>();
        }

        public void ClearFindings ()
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

        //public IEnumerable EventsFindings
        //{
        //    get { return FindingsSource(SearchFinding.TypeEnum.Event); }
        //}

        //public IEnumerable GroupsFindings
        //{
        //    get { return FindingsSource(SearchFinding.TypeEnum.Group); }
        //}

        //public IEnumerable PagesFindings
        //{
        //    get { return FindingsSource(SearchFinding.TypeEnum.Page); }
        //}

        //public IEnumerable PostsFindings
        //{
        //    get { return FindingsSource(SearchFinding.TypeEnum.Post); }
        //}

        //private IEnumerable<string> FindingsSource(SearchFinding.TypeEnum i_Type)
        //{
        //    foreach (SearchFinding finding in m_AllFindings)
        //    {
        //        if (finding.Type == i_Type)
        //        {
        //            yield return finding.Text;
        //        }
        //    }
        //}
    }
}
