//Set 
//Describe several debugging techniques and scenarios for their use.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace Activity10
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            //if (containsElement(val)) return false;
            //not wrong just messy and can cause logical errors
            if (containsElement(val))
            {
                return false;
            }
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                //if (val == elements[i])
                //    return true;
                //else
                //    return false;
                //Again not wrong because only one line
                //should include brackets to avoid logical errors
                if (val == elements[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;
        }
    }
}

