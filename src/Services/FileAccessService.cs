using System.Windows.Forms;
using DbManager.Abstractions;

namespace DbManager.Services
{
    public sealed class FileAccessService : IFileAccessService
    {
        private const string Filter = "(*.db) | *.db";
        private readonly OpenFileDialog _openFileDialog = new OpenFileDialog() { Filter = Filter };
        private readonly SaveFileDialog _saveFileDialog = new SaveFileDialog() { Filter = Filter };

        public bool ShowOpenDialog(out string filePath)
        {
            switch (_openFileDialog.ShowDialog())
            {
                case DialogResult.OK:
                    filePath = _openFileDialog.FileName;
                    return true;
                default:
                    filePath = null;
                    return false;
            }
        }

        public bool ShowSaveDialog(out string filePath)
        {
            switch (_saveFileDialog.ShowDialog())
            {
                case DialogResult.OK:
                    filePath = _saveFileDialog.FileName;
                    return true;
                default:
                    filePath = null;
                    return false;
            }
        }
    }
}