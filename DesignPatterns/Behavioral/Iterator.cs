using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This pattern provides a way to access elements from an aggregate sequentially. 
 * Microsoft's IEnumerable is one of the example of this pattern
 */

namespace DesignPatterns.Behavioral
{
    public class Element
    {
        public string Name { get; set; }
    }

    public class Iterator : IEnumerable<Element>
    {
        public Element[] array;
        public Element this[int i]
        {
            get
            { 
                return array[i];
            }
        }

        #region IEnumerable<element> Members

        public IEnumerator<Element> GetEnumerator()
        {
            foreach (Element arr in this.array)
            {
                yield return arr;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (Element arr in this.array)
            {
                yield return arr;
            }
        }

        #endregion
    }
}
