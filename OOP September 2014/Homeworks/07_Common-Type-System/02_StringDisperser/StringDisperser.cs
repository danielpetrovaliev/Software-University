using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringDisperser
{
    public class StringDisperser : IComparable<StringDisperser>, ICloneable, IEnumerable<char>
    {
        private string[] words;

        public StringDisperser(params string[] words)
        {
            this.Words = words;
        }

        public string[] Words
        {
            get { return this.words; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Constructor must have one or more arguments.");
                }
                this.words = value;
            }
        }

        public override string ToString()
        {
            return string.Join("", this.Words);
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == ((StringDisperser)obj).ToString();
        }

        public override int GetHashCode()
        {
            int hashCode = 0;

            foreach (var word in this.Words)
            {
                hashCode ^= word.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator ==(StringDisperser firstStringDisperser, StringDisperser secondStringDisperser)
        {
            return firstStringDisperser.Equals(secondStringDisperser);
        }

        public static bool operator !=(StringDisperser firstStringDisperser, StringDisperser secondStringDisperser)
        {
            return !(firstStringDisperser.Equals(secondStringDisperser));
        }

        public int CompareTo(StringDisperser other)
        {
            return string.Compare(this.ToString(), other.ToString());
        }

        public object Clone()
        {
            string[] words = new string[this.Words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = this.Words[i];
            }

            return new StringDisperser(words);
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.ToString().Length; i++)
            {
                yield return this.ToString()[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
