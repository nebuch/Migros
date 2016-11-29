namespace MonoLightTech.UnityUtil
{
    public sealed class Pair<TLeft, TRight>
    {
        public enum ComparisonMethod
        {
            Both = 0,
            First,
            Second,
            FirstOrSecond
        }

        public TLeft Left { get; set; }
        public TRight Right { get; set; }
        public ComparisonMethod Comparison { get; set; }

        public Pair(TLeft left, TRight right, ComparisonMethod comparison)
        {
            Left = left;
            Right = right;
            Comparison = comparison;
        }

        public Pair() : this(default(TLeft), default(TRight), default(ComparisonMethod))
        {
        }

        public Pair(ComparisonMethod comparison) : this(default(TLeft), default(TRight), comparison)
        {
        }

        public Pair(TLeft left, TRight right) : this(left, right, default(ComparisonMethod))
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pair<TLeft, TRight>))
                return false;

            var other = (Pair<TLeft, TRight>)obj;

            switch (Comparison)
            {
                default:
                case ComparisonMethod.Both:
                    return Left.Equals(other.Left) && Right.Equals(other.Right);
                case ComparisonMethod.First:
                    return Left.Equals(other.Left);
                case ComparisonMethod.Second:
                    return Right.Equals(other.Right);
                case ComparisonMethod.FirstOrSecond:
                    return Left.Equals(other.Left) || Right.Equals(other.Right);
            }
        }

        public override int GetHashCode()
        {
            return Left.GetHashCode() ^ Right.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Pair => [Left: {0}] [Right: {1}] [Comparison: {2}]", Left, Right, Comparison);
        }
    }
}