namespace Chap7_8
{
    // 基本クラス
    class Music
    {
        int type = 0;                       // 既定はprivate
        protected string name = "Music";

        public int Type
        {
            set
            {
                this.type = value;
            }
            get
            {
                return this.type;
            }
        }
    }
}