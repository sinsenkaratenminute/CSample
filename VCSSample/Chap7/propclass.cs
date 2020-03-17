namespace Chap7_8
{
    // Šî–{ƒNƒ‰ƒX
    class Music
    {
        int type = 0;                       // Šù’è‚Íprivate
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