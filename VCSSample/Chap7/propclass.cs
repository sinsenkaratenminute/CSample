namespace Chap7_8
{
    // ��{�N���X
    class Music
    {
        int type = 0;                       // �����private
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