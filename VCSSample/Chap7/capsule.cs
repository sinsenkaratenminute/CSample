using System;

namespace Chap7_7
{
    // ��{�N���X
    class Music
    {
        int type = 0;                       // �����private�ɂȂ�
        protected string name = "Music";

        // type�t�B�[���h�ɒl��ݒ肷��public���\�b�h
        public void SetType(int type)
        {
            this.type = type;
        }

        // �t�B�[���h�̒l���o�͂��鉼�z���\�b�h
        public virtual void PrintName()
        {
            Console.WriteLine(type);
            Console.WriteLine(name);
        }
    }

    // �h���N���X
    class Song : Music
    {
        public override void PrintName()
        {
            // this.type = 1;
            this.name = "Song";         // name�t�B�[���h�Ɂhsong�h����
            base.PrintName();           // ��{�N���X�̃��\�b�h���Ăяo��
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();        // �h���N���X�̃C���X�^���X���쐬
            s.SetType(1);             // type�t�B�[���h��1��ݒ�
                                      // s.name = "test";
            s.PrintName();              // �o�͒l�F1�@Song
        }
    }
}