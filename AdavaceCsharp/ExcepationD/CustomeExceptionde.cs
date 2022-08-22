using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.ExcepationD
{
    class CustomeExceptionde
    {
        class InvalidExprinceException : ApplicationException
        {

        }
        class Emp : Object
        {
            string nm;
            int experince;

            public string Nm
            {
                set { this.nm = value; }
                get { return nm; }
            }
            public override string ToString()
            {
                return "Name:" + nm + "xperince:" + experince;
            }
            public int Experince
            {
                set
                {
                    if (value < 0)
                        throw new InvalidExprinceException();
                    else
                        this.experince = value;
                }
                get { return experince; }
            }
        }
    }
}

