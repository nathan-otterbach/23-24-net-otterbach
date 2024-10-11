public class Cl_Counter : IDisposable
{
    private static int _count = 0;
    private int _localIndex;
    private int _counter;
    private bool _disposed = false;

    public Cl_Counter()
    {
        _localIndex = Interlocked.Increment(ref _count);
    }

    public Cl_Counter(int counter)
    {
        _counter = counter;
    }

    public int Counter
    {
        get { return _counter; }
        set { _counter = value; }
    }

    public int Count
    {
        get { return _count; }
    }

    #region IDisposable Members
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            _localIndex = Interlocked.Decrement(ref _count);
            _disposed = true;
        }
    }

    ~Cl_Counter()
    {
        Dispose(false);
    }
    #endregion
}
