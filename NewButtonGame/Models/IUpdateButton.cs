using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewButtonGame.Models
{
    public interface IUpdateButton
    {
        public void GenerateBad();

        public void Choice(int guess);

        public void ScoreIncrease();

        public void ScoreReset();


    }
}
