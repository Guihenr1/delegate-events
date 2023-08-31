namespace Study
{
    public delegate void EmailEventHandler();

    public class VideoService
    {
        public static event EmailEventHandler SendEmailUser;

        public void EncodeVideo()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Video encoded...");

            SendEmailUser += new EmailEventHandler(Events.SendEmailUser);
            SendEmailUser += new EmailEventHandler(Events.SendEmailEncoded);

            SendEmailUser.Invoke();

            Console.WriteLine("Finished...");
        }
    }
}