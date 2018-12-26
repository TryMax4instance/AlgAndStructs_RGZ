using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgAndStructs_RGZ_SuffixTree
{
    class SuffixTree
    {
        private readonly SuffixTreeEdge _root;
        private readonly List<char> _string;

        private (SuffixTreeEdge edge, char startChar, int length) startPoint;
        private int remainder;

        private int LeafCount = 0;

        public SuffixTree()
        {
            _root = new SuffixTreeEdge()
            {
                Span = SuffixTreeSpan.Zero
            };
            _string = new List<char>(16);

            remainder = 0;
        }

        public List<int> FindStr(string s)
        {
            List<int> PosList = new List<int>();
            var startPoint = _root;
            var localPosition = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (startPoint.Span.Length == localPosition)
                {
                    foreach (var item in startPoint.Children)
                    {
                        if (item.Span[0] == s[i])
                        {
                            startPoint = item;
                            localPosition = 0;
                            break;
                        }
                    }
                }
                if (startPoint == _root)
                {
                    return PosList;
                }

                if (startPoint.Span[localPosition] != s[i])
                {

                    return PosList;
                }

                localPosition++;
            }

            WatchOver(startPoint, PosList);

            return PosList;
        }

        public void WatchOver(SuffixTreeEdge edge, List<int> PosList)
        {
            if (edge.Children.Count == 0)
            {
                PosList.Add(edge.LeafNumber);
            }
            else
            {
                for (int i = 0; i < edge.Children.Count; i++)
                {
                    WatchOver(edge.Children[i], PosList);
                }                
            }
        }
        public int GetLeafNumber()
        {
            return LeafCount++;
        }

        public void NewAdd(char character)
        {
            if(remainder == 0)
            {
                startPoint = (_root, character, 0);
            }

            var currentCharIndex = _string.Count;
            _string.Add(character);
            SuffixTreeEdge tempSuffixLink = null;
            remainder++;

            while (remainder > 0)  // remainder - кол-во необходимых операций для добавления символа
            {
                SuffixTreeEdge currentEdge = null;
                var currentEdgeIndex = 0;

                for (int i = 0; i < startPoint.edge.Children.Count; i++)
                {
                    SuffixTreeEdge item = startPoint.edge.Children[i];
                    if (item.Span[0] == startPoint.startChar)
                    {
                        currentEdge = item;
                        currentEdgeIndex = i;
                        break;
                    }
                }

                if(currentEdge == null)
                {
                    var addedEdge = new SuffixTreeEdge()
                    {
                        Span = new SuffixTreeSpan(_string, currentCharIndex, null),
                        LeafNumber = GetLeafNumber(),
                    };

                    startPoint.edge.Children.Add(addedEdge);
                    
                    if (startPoint.edge != _root)
                    {
                        if (tempSuffixLink != null)
                        {
                            tempSuffixLink.SuffixLink = startPoint.edge;
                        }
                        tempSuffixLink = startPoint.edge;

                        startPoint.edge = startPoint.edge.SuffixLink ?? _root;
                    }

                    remainder--;

                    continue;
                }

                if(startPoint.length >= currentEdge.Span.Length)
                {
                    startPoint.length -= currentEdge.Span.Length;
                    startPoint.startChar = _string[currentCharIndex - startPoint.length];
                    startPoint.edge = currentEdge;

                    if (tempSuffixLink != null)
                    {
                        tempSuffixLink.SuffixLink = startPoint.edge;
                    }

                    continue;
                }

                if(currentEdge.Span[startPoint.length] == character)
                {
                    startPoint.length++;
                    return;
                }

                //Если ничего из предыдущего не вышло - делаем подразделение
                var tail = new SuffixTreeSpan(_string, startPoint.length + currentEdge.Span.From, currentEdge.Span._to);
                var head = new SuffixTreeSpan(_string, currentEdge.Span.From, startPoint.length + currentEdge.Span.From);
                var newSpan = new SuffixTreeSpan(_string, currentCharIndex, null);

                var newEdge = new SuffixTreeEdge()
                {
                    Span = newSpan,
                    LeafNumber = GetLeafNumber(),
                };

                currentEdge.Span = tail;

                var headEdge = new SuffixTreeEdge()
                {
                    Children = new List<SuffixTreeEdge>()
                    {
                        currentEdge,
                        newEdge
                    },
                    Span = head
                };

                startPoint.edge.Children[currentEdgeIndex] = headEdge;

                if(tempSuffixLink != null)
                {
                    tempSuffixLink.SuffixLink = headEdge;
                }
                tempSuffixLink = headEdge;

                if(startPoint.edge == _root)
                {
                    startPoint.length--;
                    startPoint.startChar = _string[currentCharIndex - startPoint.length];
                }
                else
                {
                    startPoint.edge = startPoint.edge.SuffixLink ?? _root;
                }

                remainder--;
            }
        }

        public void AddRange(IEnumerable<char> characters)
        {
            foreach (var item in characters)
            {
                NewAdd(item);
            }
        }

        public bool IsSuffixExist(string str)
        {
            var startPoint = _root;
            var localPosition = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(startPoint.Span.Length == localPosition)
                {
                    foreach (var item in startPoint.Children)
                    {
                        if(item.Span[0] == str[i])
                        {
                            startPoint = item;
                            localPosition = 0;
                            break;
                        }
                    }
                }
                if (startPoint.Span[localPosition] != str[i])
                {
                    return false;
                }
                localPosition++;
            }
            return true;
        }

        public int GetTreeSize()
        {
            var sum = _string.Count * sizeof(char);
            //Размер = from, to, str_ptr, children_ptrs, suffix_link_ptr
            var childrenCount = GetEdgeCount(_root);
            sum += (childrenCount + 1) * (sizeof(int) * 2 + sizeof(Int64)*2) + childrenCount*sizeof(Int64);
            return sum;
        }

        private int GetEdgeCount(SuffixTreeEdge root)
        {
            var sum = root.Children.Count;
            foreach (var item in root.Children)
            {
                sum += GetEdgeCount(item);
            }
            return sum;
        }
    }

    class SuffixTreeEdge
    {
        public SuffixTreeEdge()
        {
            Children = new List<SuffixTreeEdge>();
        }

        internal SuffixTreeSpan Span { get; set; }
        internal List<SuffixTreeEdge> Children { get; set; }
        internal SuffixTreeEdge SuffixLink { get; set; }        
        internal int LeafNumber { get; set; }
    }
}
