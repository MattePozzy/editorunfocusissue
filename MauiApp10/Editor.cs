using System.Runtime.CompilerServices;

namespace MauiApp10
{
    public class VolosEditor : VolosEntry
    {
        public bool AutoSize
        {
            get { return (bool)GetValue(AutoSizeProperty); }
            set { SetValue(AutoSizeProperty, value); }
        }
        public static readonly BindableProperty AutoSizeProperty = BindableProperty.Create(
            propertyName: nameof(AutoSize),
            returnType: typeof(bool),
            declaringType: typeof(VolosEditor),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay
        );

        private readonly Editor Editor;

        public VolosEditor()
        {
            MinimumHeightRequest = 100;
            IsHintAlwaysFloated = true;

            Editor = new()
            {
                //FontFamily = "Arial",
                //FontSize = 18,
                IsSpellCheckEnabled = false,
                IsTextPredictionEnabled = false,
                AutoSize = EditorAutoSizeOption.TextChanges,
            };

            Editor.SetBinding(Editor.TextProperty, new Binding(path: nameof(Valore), source: this, mode: BindingMode.TwoWay));

            Content = Editor;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == AutoSizeProperty.PropertyName)
            {
                if (AutoSize)
                {
                    HeightRequest = -1;
                    MinimumHeightRequest = -1;
                }
                else
                {
                    HeightRequest = -1;
                    MinimumHeightRequest = 200;
                }
            }
        }
    }
}
