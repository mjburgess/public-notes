using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{

    public interface IPlayable
    {
        void Play(ProgressDel progressDel);
        void Pause();
        void Stop();
        TimeSpan Duration { get; }
    }
    public delegate void ProgressDel(int percent);

}
