using MobileGame.Enums;
using MobileGame.Tools;
using UnityEngine.Advertisements;

namespace Platformer.Player
{
    public class ProfilePlayer
    {
        public ProfilePlayer(float speedCar, UnityAdsTools unityAdsTools)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(speedCar);
            AnaliticTools = new AnaliticTools();
            AdsShower = unityAdsTools;
            AdsListener = unityAdsTools;
        }

        public SubscriptionProperty<GameState> CurrentState { get; }

        public Car CurrentCar { get; }

        public IAnaliticTools AnaliticTools { get; }

        public IAdsShower AdsShower { get; }
        
        public IUnityAdsListener AdsListener { get; }
    }
}