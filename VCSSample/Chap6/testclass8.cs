using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_12
{
    class TestClass
    {
        // 2��int�^�̐��������Z���郁�\�b�h
        long AddNums(int a, int b)
        {
            return a + b;
        }

        // 3��int�^�̐��������Z���郁�\�b�h
        long AddNums(int a, int b, int c)
        {
            return a + b + c;
        }

        // 2��long�^�̐��������Z���郁�\�b�h
        long AddNums(long a, long b)
        {
            return a + b;
        }

        // 2�̎Q�Ɠn����int�^�̐��������Z���郁�\�b�h
        long AddNums(ref int a, int b)
        {
            return a + b;
        }
    }
}