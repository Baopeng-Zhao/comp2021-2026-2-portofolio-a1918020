public class ScoreComparer: IComparer<ScoreEntry>
{
    public int Compare(ScoreEntry x, ScoreEntry y)
    {
        if(x.Score < y.Score)
        {
            return 1;
        }
        if(x.Score > y.Score)
        {
            return -1;
        }
        return 0;
    }
}