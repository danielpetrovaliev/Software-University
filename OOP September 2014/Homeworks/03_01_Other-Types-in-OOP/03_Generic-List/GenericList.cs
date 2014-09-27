using System;

[Version("0.11")]
public class GenericList<T>
    where T : IComparable
{
    const int DefaultCapacity = 16;

	private T[] elements;
	private int count = 0;

	public GenericList(int capacity = DefaultCapacity)
	{
		elements = new T[capacity];
	}
    public int Count
    {
        get
        {
            return this.count;
        }
    }
    public int Length
    {
        get { return this.elements.Length; }
    }

    public void Expand()
    {
        T[] newArray = new T[this.Length + 1];
        Array.Copy(this.elements, newArray, this.Length);
        this.elements = newArray;
    }

    public void Add(T element)
    {
        if (count >= this.Length)
        {
            this.Expand();
        }

        this.elements[this.Count] = element;
        count++;
    }

    public T Access(int index)
    {
        if (count > elements.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
                "The list capacity of {0} was exceeded.", elements.Length));
        }

        return this.elements[index];
    }

    public void Remove(int index)
    {
        if (count > elements.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
                "The list capacity of {0} was exceeded.", elements.Length));
        }

        for (int i = index; i < this.count - 1; i++)
        {
            this.elements[i] = this.elements[i + 1];
        }

        this.count--;
        this.elements[this.Count] = default(T);
    }

    public void Insert(T element, int index)
    {
        if (count > elements.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
                "The list capacity of {0} was exceeded.", elements.Length));
        }

        for (int i = this.count; i > index; i--)
        {
            this.elements[i] = this.elements[i - 1];
        }
        this.count++;
        this.elements[index] = element;
    }

    public int IndexOf(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].Equals(element))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Contains(T element) 
    {
        if (this.IndexOf(element) != -1)
        {
            return true;
        }

        return false;
    }

    public void Clear()
    {
        this.elements = new T[this.Count];
        this.count = 0;
    }

    public T Min()
    {
        if (this.Count <= 0)
        {
            throw new ArgumentNullException("Can not get min value of empty list");
        }
        T min = this.elements[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(min) < 0)
            {
                min = elements[i];
            }
        }
        return min;
    }

    public T Max()
    {
        if (this.Count <= 0)
        {
            throw new ArgumentNullException("Can not get min value of empty list");
        }
        T max = this.elements[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(max) > 0)
            {
                max = elements[i];
            }
        }
        return max;
    }

    // TODO: method Remove

    public override string ToString()
    {
        string result = String.Join(", ", this.elements);
        return result.Trim(' ', ',');
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = elements[index];
            return result;
        }
    }
}
