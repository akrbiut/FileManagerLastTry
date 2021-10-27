using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace FileManagerLastTry.ML
{
    public class ModelInteractive
    {
        public string FileStatus(int TotTime, int PagInf, int WorInf, int CharInf, int LineIf, int ParInf)
        {
            var sampleData = new MLModel.ModelInput()
            {
                Totaltime = TotTime,
                Pages = PagInf,
                Words = WorInf,
                Characters = CharInf,
                Lines = LineIf,
                Paragraphs = ParInf,
            };

            //Load model and predict output
            var result = MLModel.Predict(sampleData);
            return result.Prediction;
        }
      
    }
}
