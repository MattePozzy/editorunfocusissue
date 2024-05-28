using Syncfusion.Maui.Core;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp10
{
    public class VolosEntry : SfTextInputLayout
    {
        #region Bindable properties        
        public string Valore
        {
            get { return (string)GetValue(ValoreProperty); }
            set { SetValue(ValoreProperty, value); }
        }
        public static readonly BindableProperty ValoreProperty = BindableProperty.Create(
            propertyName: nameof(Valore),
            returnType: typeof(string),
            declaringType: typeof(VolosEntry),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.TwoWay
        );

        public bool Required
        {
            get { return (bool)GetValue(RequiredProperty); }
            set { SetValue(RequiredProperty, value); }
        }
        public static readonly BindableProperty RequiredProperty = BindableProperty.Create(
            propertyName: nameof(Required),
            returnType: typeof(bool),
            declaringType: typeof(VolosEntry),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay
        );

        public string Icona
        {
            get { return (string)GetValue(IconaProperty); }
            set { SetValue(IconaProperty, value); }
        }
        public static readonly BindableProperty IconaProperty = BindableProperty.Create(
            propertyName: nameof(Icona),
            returnType: typeof(string),
            declaringType: typeof(VolosEntry),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.TwoWay
        );

        public Color IconaColore
        {
            get { return (Color)GetValue(IconaColoreProperty); }
            set { SetValue(IconaColoreProperty, value); }
        }
        public static readonly BindableProperty IconaColoreProperty = BindableProperty.Create(
            propertyName: nameof(IconaColore),
            returnType: typeof(Color),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );

        public bool IsPassword
        {
            get { return (bool)GetValue(IsPasswordProperty); }
            set { SetValue(IsPasswordProperty, value); }
        }
        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(
            propertyName: nameof(IsPassword),
            returnType: typeof(bool),
            declaringType: typeof(VolosEntry),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay
        );

        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }
        public static readonly BindableProperty IsReadOnlyProperty = BindableProperty.Create(
            propertyName: nameof(IsReadOnly),
            returnType: typeof(bool),
            declaringType: typeof(VolosEntry),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay
        );

        public ReturnType ReturnType
        {
            get { return (ReturnType)GetValue(ReturnTypeProperty); }
            set { SetValue(ReturnTypeProperty, value); }
        }
        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create(
            propertyName: nameof(ReturnType),
            returnType: typeof(ReturnType),
            declaringType: typeof(VolosEntry),
            defaultValue: ReturnType.Done,
            defaultBindingMode: BindingMode.TwoWay
        );

        #region Abilitazione campo
        public string Abilitazione
        {
            get { return (string)GetValue(AbilitazioneProperty); }
            set { SetValue(AbilitazioneProperty, value); }
        }
        public static readonly BindableProperty AbilitazioneProperty = BindableProperty.Create(
            propertyName: nameof(Abilitazione),
            returnType: typeof(string),
            declaringType: typeof(VolosEntry),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay
        );

        public bool? IsNew
        {
            get { return (bool?)GetValue(IsNewProperty); }
            set { SetValue(IsNewProperty, value); }
        }
        public static readonly BindableProperty IsNewProperty = BindableProperty.Create(
            propertyName: nameof(IsNewProperty),
            returnType: typeof(bool?),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );
        #endregion

        public ICommand FocusedCommand
        {
            get { return (ICommand)GetValue(FocusedCommandProperty); }
            set { SetValue(FocusedCommandProperty, value); }
        }
        public static readonly BindableProperty FocusedCommandProperty = BindableProperty.Create(
            propertyName: nameof(FocusedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );

        public ICommand UnFocusedCommand
        {
            get { return (ICommand)GetValue(UnFocusedCommandProperty); }
            set { SetValue(UnFocusedCommandProperty, value); }
        }
        public static readonly BindableProperty UnFocusedCommandProperty = BindableProperty.Create(
            propertyName: nameof(UnFocusedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );

        public ICommand ValueChangedCommand
        {
            get { return (ICommand)GetValue(ValueChangedCommandProperty); }
            set { SetValue(ValueChangedCommandProperty, value); }
        }
        public static readonly BindableProperty ValueChangedCommandProperty = BindableProperty.Create(
            propertyName: nameof(ValueChangedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );

        public object ValueChangedCommandParameter
        {
            get { return GetValue(ValueChangedCommandParameterProperty); }
            set { SetValue(ValueChangedCommandParameterProperty, value); }
        }
        public static readonly BindableProperty ValueChangedCommandParameterProperty = BindableProperty.Create(
            propertyName: nameof(ValueChangedCommandParameter),
            returnType: typeof(object),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );

        public bool HintVuoto
        {
            get { return (bool)GetValue(HintVuotoProperty); }
            set { SetValue(HintVuotoProperty, value); }
        }
        public static readonly BindableProperty HintVuotoProperty = BindableProperty.Create(
            propertyName: nameof(HintVuoto),
            returnType: typeof(bool),
            declaringType: typeof(VolosEntry),
            defaultValue: false,
            defaultBindingMode: BindingMode.OneWay
        );

        public ICommand EseguiOnInvioCommand
        {
            get { return (ICommand)GetValue(EseguiOnInvioCommandProperty); }
            set { SetValue(EseguiOnInvioCommandProperty, value); }
        }
        public static readonly BindableProperty EseguiOnInvioCommandProperty = BindableProperty.Create(
            propertyName: nameof(EseguiOnInvioCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(VolosEntry),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay
        );
        #endregion

        private Entry Entry;
        private string OriginalHint;

        public VolosEntry()
        {
            Init();
        }

        public void Init()
        {
            ShowHint = true;
            ShowHelperText = false;
            ReserveSpaceForAssistiveLabels = false;
            ShowLeadingView = false;
            ContainerType = ContainerType.Filled;

            Entry = new();
            Entry.SetBinding(Entry.TextProperty, new Binding(path: nameof(Valore), source: this, mode: BindingMode.TwoWay));
            Entry.IsReadOnly = IsReadOnly;

            Content = Entry;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            if (EseguiOnInvioCommand != null) EseguiOnInvioCommand?.Execute(null);
        }

        public void SetEntryEnabled(bool enabled)
        {
            Entry.IsEnabled = enabled;
        }

        public bool CheckEntryEnabled()
        {
            return Entry.IsEnabled;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(Required):
                    RequiredBehavior();
                    break;
                case nameof(Hint):
                    if (Hint != null && string.IsNullOrEmpty(OriginalHint) && !HintVuoto) OriginalHint = (string)Hint.Clone();
                    break;
                case nameof(IconaColore):
                case nameof(Icona):
                    IconaBehavior();
                    break;
                case nameof(IsPassword):
                    IsPasswordBehavior();
                    break;
                case nameof(ReturnType):
                    ReturnTypeBehavior();
                    break;
                case nameof(IsNew):
                case nameof(Abilitazione):
                    AbilitazioneBehavior();
                    break;
                case nameof(FocusedCommand):
                    Content.Focused -= Input_Focused;
                    Content.Focused += Input_Focused;
                    break;
                case nameof(UnFocusedCommand):
                    Content.Unfocused -= InputView_Unfocused;
                    Content.Unfocused += InputView_Unfocused;
                    break;
                case nameof(IsReadOnly):
                    Entry.IsReadOnly = IsReadOnly;
                    break;

                case nameof(EseguiOnInvioCommand):
                    if (EseguiOnInvioCommand != null)
                    {
                        Entry.Completed -= Entry_Completed;
                        Entry.Completed += Entry_Completed;
                    }
                    break;
                case nameof(Valore):
                    ValueChangedCommand?.Execute(null);
                    break;

            }
        }

        private void SchemaCampoBehavior()
        {
            //if (Content is Entry input)
            //{
            //    int maxLength = SchemaCampo?.MaximumLengthInCharacters ?? int.MaxValue;
            //    CharMaxLength = maxLength;
            //    input.MaxLength = maxLength;
            //}
            // Fatto con oggetto SF
            //if (Content is SfMaskedEntry input)
            //{
            //    // SF https://www.syncfusion.com/support/directtrac/incidents/242778
            //    int maxLength = SchemaCampo?.Character_maximum_length ?? int.MaxValue;
            //    CharMaxLength = maxLength;
            //    input.MaskType = MaskedEntryMaskType.RegEx;
            //    input.Mask = @"\w{0," + maxLength + "}";
            //}
        }

        private void InputView_Unfocused(object sender, FocusEventArgs e)
        {
            CheckRequired();
            UnFocusedCommand.Execute(e);
        }

        private void Input_Focused(object sender, FocusEventArgs e)
        {
            FocusedCommand.Execute(e);
        }

        private void AbilitazioneBehavior()
        {
            if (!string.IsNullOrEmpty(Abilitazione))
            {
                //if (!IsEnabled)
                //{
                //    IsVisible = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.TipoAbilitazione.abilitato);
                //}
                //else
                //{
                //    IsEnabled = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.GetTipoAbil(IsNew ?? false));
                //    IsVisible = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.TipoAbilitazione.abilitato);
                //    Required = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.TipoAbilitazione.obbligatorio);
                //}
            }
            //bool nonGestito = !IsEnabled.HasValue;
            //bool gestitoAbilitato = IsEnabled.HasValue && IsEnabled.Value;

            //if (nonGestito || gestitoAbilitato)
            //{
            //    if (!string.IsNullOrEmpty(Abilitazione) && IsNew != null)
            //    {
            //        IsEnabled = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.GetTipoAbil(IsNew.Value));
            //        IsVisible = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.TipoAbilitazione.abilitato);
            //        Required = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.TipoAbilitazione.obbligatorio);
            //    }
            //}
            //else
            //{
            //    IsVisible = AbilitazioniAppBase.GetAbilitazione(Abilitazione, AbilitazioniAppBase.TipoAbilitazione.abilitato);
            //}
        }

        private void ReturnTypeBehavior()
        {
            Entry.ReturnType = ReturnType;
        }

        private void IsPasswordBehavior()
        {
            Entry.IsPassword = IsPassword;
        }

        private void IconaBehavior()
        {
            Label lblIcona = new()
            {
                Text = Icona,
                //FontFamily = Costanti.Font.FontIcone.ToString(),
                //FontSize = FontSize.Medium,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            if (IconaColore != null) lblIcona.TextColor = IconaColore;

            ShowLeadingView = true;
            LeadingViewPosition = ViewPosition.Inside;
            LeadingView = lblIcona;
        }

        private void RequiredBehavior()
        {
            // TODO controllare schemacampo
            //if (SchemaCampo != null)
            //{
            //    if (length > SchemaCampo.Character_maximum_length)
            //    {
            //        valido = false;
            //        HasError = true;
            //        ErrorText = HasError ? TS.Translate("AppMobileComuni.LunghezzaCampo") : "";
            //    }
            //}

            if (Required)
            {
                Label tView = new()
                {
                    //Text = MaterialFontIcons.Asterisk,
                    //FontFamily = Costanti.Font.FontIcone.ToString(),
                    //TextColor = Utility.GetResources<Color>(Utility.IsDarkTheme() ? "PrimaryDark" : "Primary")
                };

                ShowTrailingView = true;
                TrailingView = tView;

                Unfocused += VolosEntry_Unfocused;
            }
            else
            {
                ShowTrailingView = false;
            }
        }

        private void VolosEntry_Unfocused(object sender, FocusEventArgs e)
        {
            CheckRequired();
        }

        public void CheckRequired(bool reset = false)
        {
            Color normale = Colors.Orange;
            //Utility.GetResources<Color>(Utility.IsDarkTheme() ? "PrimaryDark" : "Primary");

            if (IsEnabled && !reset)
            {
                Color rosso = Colors.Red;
                //Utility.GetResources<Color>("Rosso");
                HasError = Required && string.IsNullOrEmpty(Valore);

                if (HasError)
                {
                    SetHint(true);
                    HintLabelStyle = new LabelStyle { TextColor = rosso };
                    SetTrailingViewColor(rosso);
                }
                else
                {
                    SetHint(false);
                    HintLabelStyle = new LabelStyle { TextColor = normale };
                    SetTrailingViewColor(normale);
                }
            }
            else
            {
                // Come se non avesse il required.
                HasError = false;
                SetHint(false);
                HintLabelStyle = new LabelStyle { TextColor = normale };
                SetTrailingViewColor(normale);
            }
        }

        private void SetTrailingViewColor(Color colore)
        {
            if (TrailingView != null)
            {
                Label tView = (Label)TrailingView;
                tView.TextColor = colore;
            }
        }

        private void SetHint(bool error)
        {
            if (error)
            {
                //if (!HintVuoto)
                //{
                //    Hint = $"{OriginalHint} - {Utility.GetTS().Translate("AppMobileComuni.camporequired")}";
                //}
                //else
                //{
                //    Hint = $"{Utility.GetTS().Translate("AppMobileComuni.camporequired")}";
                //}
            }
            else
            {
                if (!HintVuoto)
                {
                    Hint = OriginalHint;
                }
                else
                {
                    Hint = string.Empty;
                }
            }
        }
    }
}