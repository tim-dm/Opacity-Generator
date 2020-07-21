using OpacEngine;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace OGWPF.ViewModels
{
    public class GeneratorViewModel : BaseViewModel
    {
        public ObservableCollection<Opacity> Opacities { get; } = new ObservableCollection<Opacity>();

        public int BrightnessFactor
        {
            get { return OpacitySettings.BrightnessFactor; }
            set
            {
                if (value == OpacitySettings.BrightnessFactor)
                    return;

                if (value < 1 || value > 127)
                    OpacitySettings.BrightnessFactor = 1;
                else
                    OpacitySettings.BrightnessFactor = value;

                OnPropertyChanged();                
                createOpacities();                
            }
        }

        public int OpacityCount { get { return Opacities.Count(); } }

        public int OpacityResolution
        {
            get { return OpacitySettings.OpacityResolution; }
        }

        public string OpacityFormat
        {
            get { return OpacitySettings.OpacityFormat; }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand CommandSetResolution { get; set; }
        public ICommand CommandSetFormat { get; set; }

        public GeneratorViewModel()
        {
            SaveCommand = new RelayCommand<object>(SaveOpacities);
            CommandSetResolution = new RelayCommand<object>(SetResolution);
            CommandSetFormat = new RelayCommand<object>(SetFormat);
            createOpacities();
        }

        private void SetResolution(object obj)
        {
            if (obj == null)
                return;

            OpacitySettings.OpacityResolution = Convert.ToInt32(obj);
            OnPropertyChanged("OpacityResolution");
        }

        private void SetFormat(object obj)
        {
            if (obj == null)
                return;

            OpacitySettings.OpacityFormat = (string)obj;
            OnPropertyChanged("OpacityFormat");
        }

        private void createOpacities()
        {
            int currentBrightness = 0;
            int maxShades = 255 / BrightnessFactor;

            Opacities.Clear();
            for (int i = 0; i < maxShades; ++i)
            {
                Opacities.Add(new Opacity(currentBrightness, currentBrightness, currentBrightness));
                currentBrightness += BrightnessFactor; 
            }

            OnPropertyChanged("OpacityCount");
        }

        private void SaveOpacities(object obj)
        {
            if(Opacities.Count() > 0)
            {
                foreach (Opacity opac in Opacities)
                {
                    opac.Save();
                }
            }
        }
    }
}
