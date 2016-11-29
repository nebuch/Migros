namespace MonoLightTech.UnityUtil
{
    public class StructWrapper<T> where T : struct
    {
        public T Value { get; set; }

        public StructWrapper(T value)
        {
            Value = value;
        }

        public StructWrapper() : this(default(T))
        {
        }
    }
}