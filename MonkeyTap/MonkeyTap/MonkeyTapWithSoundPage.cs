namespace MonkeyTap
{
    public class MonkeyTapWithSoundPage : MonkeyTap.MonkeyTapPage
    {
        const int errorDuration = 500;

        double[] frequencies = { 523.25, 622.25, 739.99, 880 };

        public override void FlashBoxView(int index)
        {
            SoundPlayer.PlaySound(frequencies[index], flashDuration);
            base.FlashBoxView(index);
        }

        protected override void EndGame()
        {
            SoundPlayer.PlaySound(65.4, errorDuration);
            base.EndGame();
        }
    }
}
