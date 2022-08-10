using ECommerce.Models;
using System.Text.Json;

namespace ECommerce.Extensions
{
    public static class SessionExtension
    {
        public static void SetJson<T>(this ISession session, string key, T instance)
        {
            session.SetString(key, JsonSerializer.Serialize(instance));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            return session.GetString(key) != null ? JsonSerializer.Deserialize<T>(session.GetString(key)) : default(T);
        }
    }
}
