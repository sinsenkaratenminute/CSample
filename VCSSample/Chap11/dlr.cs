using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
namespace Chap11_dlr
{
    class MainClass
    {
        static void Main()
        {
            ScriptRuntime py = Python.CreateRuntime();
            dynamic sample = py.UseFile( "sample.py" );
            
            // Python�̃N���X�̃C���X�^���X����
            dynamic p = sample.PythonSample();

            Console.WriteLine( p.getMessage( "C#" ) );
        }
    }
}