using BA_Mobile.Core.Interfaces;
using System.Windows.Input;

namespace BA_Mobile.Core.ViewModels
{
    public abstract class ViewModelBase : ExtendedBindableObject, INavigationAware, IInitialize, IInitializeAsync, IDestructible, IApplicationLifecycleAware, IDisposable
    {
        protected INavigationService _navigationService { get; }
        protected IPageDialogService _pageDialogs { get; }
        protected IDialogService _dialogs { get; }
        protected IHUDProvider _hUDProvider { get; }

        public bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        private string title;
        public virtual string Title { get => title; set => SetProperty(ref title, value); }

        private bool isBusy = false;
        public bool IsBusy { get => isBusy; set => SetProperty(ref isBusy, value); }
        public int[] _vehicleGroups;
        private bool isLoading = true;
        public bool IsLoading { get => isLoading; set => SetProperty(ref isLoading, value); }

        public bool isNotFound;
        public bool IsNotFound { get => isNotFound; set => SetProperty(ref isNotFound, value); }

        public ViewModelBase(ViewModelBaseServices baseServices)
        {
            _navigationService = baseServices.NavigationService;
            _pageDialogs = baseServices.PageDialogs;
            _dialogs = baseServices.Dialogs;
            _hUDProvider = baseServices._hUDProvider;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public void Destroy()
        {
            OnDestroy();
        }

        public virtual void OnDestroy()
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        private bool viewHasAppeared;
        public bool ViewHasAppeared { get => viewHasAppeared; set => SetProperty(ref viewHasAppeared, value); }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            if (!ViewHasAppeared)
            {
                OnPageAppearingFirstTime();

                ViewHasAppeared = true;
            }
        }

        public virtual void OnPageAppearingFirstTime()
        {
        }

        public virtual void OnPushed()
        {
        }

        public virtual void OnSleep()
        {
        }

        public virtual void OnResume()
        {
            if (IsConnected)
            {
            }
        }

        public virtual void Dispose()
        {
        }

        protected void SafeExecute(Action action)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected async void SafeExecute(Func<Task> func)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                await func?.Invoke();
            }
            catch (Exception)
            {
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected void TryExecute(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception)
            {
            }
        }

        protected async void TryExecute(Func<Task> func)
        {
            try
            {
                await func?.Invoke();
            }
            catch (Exception)
            {
            }
        }

        protected Task RunOnBackground(Action action, Action onComplete = null, Action<Exception> onError = null, Action finalAction = null, CancellationTokenSource cts = null, bool showLoading = false)
        {
            if (showLoading)
                DependencyService.Get<IHUDProvider>().DisplayProgress("");

            return (cts != null ? Task.Run(action, cts.Token) : Task.Run(action)).ContinueWith(task => MainThread.BeginInvokeOnMainThread(() =>
            {
                if (task.Status == TaskStatus.RanToCompletion && !task.IsCanceled && (cts == null ? true : !cts.IsCancellationRequested))
                {
                    onComplete?.Invoke();
                }
                else if (task.IsFaulted)
                {
                    onError?.Invoke(task.Exception);
                }

                if (showLoading)
                    DependencyService.Get<IHUDProvider>().Dismiss();

                finalAction?.Invoke();
            }));
        }

        protected Task RunOnBackground<T>(Func<Task<T>> action, Action<T> onComplete = null, Action<Exception> onError = null, Action finalAction = null, CancellationTokenSource cts = null, bool showLoading = false)
        {
            if (showLoading)
                DependencyService.Get<IHUDProvider>().DisplayProgress("");

            return (cts != null ? Task.Run(action, cts.Token) : Task.Run(action)).ContinueWith(task => MainThread.BeginInvokeOnMainThread(() =>
            {
                if (task.Status == TaskStatus.RanToCompletion && !task.IsCanceled && (cts == null ? true : !cts.IsCancellationRequested))
                {
                    onComplete?.Invoke(task.Result);
                }
                else if (task.IsFaulted)
                {
                    onError?.Invoke(task.Exception);
                }

                if (showLoading)
                    DependencyService.Get<IHUDProvider>().Dismiss();

                finalAction?.Invoke();
            }));
        }

        public ICommand ClosePageCommand
        {
            get
            {
                return new Command(() =>
                {
                    SafeExecute(async () =>
                    {
                        var res = await _navigationService.GoBackAsync();
                    });
                });
            }
        }

        public ICommand BackPageCommand
        {
            get
            {
                return new Command(() =>
                {
                    SafeExecute(async () =>
                    {
                        var res = await _navigationService.GoBackAsync();
                    });
                });
            }
        }
    }
}