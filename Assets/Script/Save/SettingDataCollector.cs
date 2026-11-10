public class SettingDataCollector
{
    // 動作確認用。falseにする
    private readonly bool useDummyData = true;

    public SettingData Collect()
    {
        SettingData data = new SettingData();
        CollectVolume(ref data);
        // Collect[設定名](ref data) を順次追加
        return data;
    }

    private void CollectVolume(ref SettingData data)
    {
        data.volumes = GetVolumes();
    }

    private Volumes GetVolumes()
    {
        if (useDummyData)
        {
            return new Volumes(0.8f, 0.6f, 0.4f); // 仮データ
        }

        AudioSettings audio = AudioSettings.Instance;
        return new Volumes(
            audio.GetMasterVolume(),
            audio.GetSEVolume(),
            audio.GetBGMVolume());
    }
}