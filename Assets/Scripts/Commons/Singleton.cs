
/// <summary>
/// シングルトンの基底クラス
/// </summary>
/// <typeparam name="T">シングルトンにしたい派生クラス</typeparam>
public class Singleton<T> where T : class, new()
{
    private static T instance = null;

    public static T GetInstance()
    {
        if (instance == null)
        {
            instance = new T();
        }

        return instance;
    }
}
