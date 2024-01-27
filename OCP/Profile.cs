using System.Text.Json;

public class Profile
{
   IProfile _profile;
   public Profile(IProfile profile)
   {
      _profile = profile;
   }
   public void AddProfile(object profileInfo)
   {
       _profile.AddProfile(profileInfo);
   }
   public string ViewProfile()
   {
     return _profile.ViewProfile();
   }
}