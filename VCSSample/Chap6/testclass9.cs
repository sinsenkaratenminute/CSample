using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_13
{
    class TestClass
    {
        // int�^�̒l��Ԃ����\�b�h
        int AddNums(int a, int b)
        {
            return a + b;
        }
/*
        // �߂�l�̃f�[�^�^���قȂ��Ă��p�����[�^�̃f�[�^�^�������Ȃ̂ŃG���[
        long AddNums(int c, int d)
        {
            return c + d;
        }
*/
        long AddNums(out int a, int b)
        {
            a = b;
            return a;
        }
/*
        // ref��out���قȂ��Ă������f�[�^�^�ƂȂ�̂ŃG���[
        long AddNums(ref int a, int b)
        {
            return a + b;
        }
*/
    }
}