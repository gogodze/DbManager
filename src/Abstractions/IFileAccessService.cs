using System.Windows.Forms;

namespace DbManager.Abstractions
{
    public interface IFileAccessService
    {
        bool ShowOpenDialog(out string filePath);
        bool ShowSaveDialog(out string filePath);
    }
}