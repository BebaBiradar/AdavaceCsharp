using System;
using System.Collections.Generic;
using System.Text;

namespace AdavaceCsharp.CollectionD
{

    //Generic Custom TYPE
    class SS<T>
    {
        private T obj;
        public T Obj { get => obj; set => obj = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            SS<float> s1 = new SS<float>();
            s1.Obj = 4.5f;
            float d = s1.Obj;//remove element

        }
    }
    //non-genric custome
    class S
    {
        private Object obj;
        public object Obj { get =>obj; set => obj = value; }
    }
    class Test1
    {
        static void Main(string[] args)
        {
            S s = new S();
            s.Obj = "omekar";
            s.Obj = 9000;
            int x = (int)s.Obj;//remove element

        }


    }

}
