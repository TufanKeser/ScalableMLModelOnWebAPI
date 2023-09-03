using Microsoft.ML.Data;
using Microsoft.ML.Runtime.Api;

namespace Scalable.Model.DataModels
{
    public class SampleObservation
    {
        [ColumnName("Label")]
        public bool IsToxic { get; set; }


        [ColumnName("Text")]
        public string SentimentText { get; set; }

    }
}
