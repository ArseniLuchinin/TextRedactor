using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Kyrat4Xenia
{   
    class OpendFile
    {
        private Stack<String> RedoStack = new Stack<String>();
        private Stack<String> UndStack = new Stack<String>();

        public String Undo
        {
            get
            {
                if (UndStack.Count > 0)
                {
                    String StrPop = UndStack.Pop();
                    RedoStack.Push(StrPop.Substring(0, StrPop.Length));
                    if (UndStack.Count > 0)
                    {
                        StrPop = UndStack.Pop();
                        return StrPop;
                    }
                    else return "";
                }
                else
                    return "";
            }
            set
            {
                UndStack.Push(value);
            }
        }

        public String Redo
        {
            get
            {
                if (RedoStack.Count > 0)
                    return RedoStack.Pop();
                else
                    return null;
            }
        }

        public String path { get; private set; }
        public String TextInBox { get; set; }


        public OpendFile(String pathToFile, String text)
        {
            path = pathToFile;
            TextInBox = text;
        }
    }

    class OpendInMenuFile : ToolStripMenuItem
    {
        public OpendFile file;
        public OpendInMenuFile(OpendFile o)
        {
            file = o;
        }
    }

    class OpendInMenuFileList : IEnumerable
    {   
        List<OpendInMenuFile> list = new List<OpendInMenuFile>();
        ToolStripItemCollection Menu;
        public OpendInMenuFileList(ToolStripItemCollection l) 
        {
            Menu = l;
        }
        public void Add(OpendInMenuFile d)
        {
            Menu.Add(d);
            list.Add(d);
        }
        public int Count
        {
            get { return list.Count; }
        }
        public void Remove(OpendInMenuFile d)
        {
            Menu.Remove(d);
            list.Remove(d);
        }
        public OpendInMenuFile this[int i]
        {
            get
            {
                return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public OpendInMenuFileEnumerator GetEnumerator() => new OpendInMenuFileEnumerator(list);
    }

    class OpendInMenuFileEnumerator : IEnumerator<OpendInMenuFile>
    {
        List<OpendInMenuFile> list;
        int pos = 0;
        public OpendInMenuFileEnumerator(List<OpendInMenuFile> l)
        {
            list = l;
            Reset();
        }
        public void Reset()
        {
            pos = -1;
        }
        public void Dispose() { }
        public bool MoveNext()
        {
            pos++;
            if (pos >= list.Count)
                return false;
            return true;
        }
        public OpendInMenuFile Current
        {
            get =>
            list[pos];
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

    }
}
