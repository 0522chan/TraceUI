using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using System.Collections.ObjectModel;
using System.Windows;
using TraceUI.Model;

namespace TraceUI.ViewModel
{
    class ViewModel : ViewModelBase
    {
        Model.Model m = null;

        public ViewModel()
        {
            m = new Model.Model();
            AddData();
        }

        ObservableCollection<Model.Model> _sampleDatas = null;
        public ObservableCollection<Model.Model> SampleDatas
        {
            get
            {
                if (_sampleDatas == null)
                {
                    _sampleDatas = new ObservableCollection<Model.Model>();
                }
                return _sampleDatas;
            }
            private set
            {          
                _sampleDatas = value;
            }

        }
        public void AddData()
        {
            Model.Model m = new Model.Model();
            m.TimeStamp = 3774.405045;
            m.StartOfFrame = null;
            m.Chn = null;
            m.ID = "1CF";
            m.Name = null;
            m.Dr = "NONE";
            m.DLC = 8;
            m.Data = 00000000000000;

            SampleDatas.Add(m);
        }
        


    }

}
