namespace Tanjameh.Features.Admin.Media.Model;


public class SelectedMedia
{
    public bool Selected { get; set; }
    public int MediaId { get; set; }
}
public class SelectedProductMedia
{
    public int ProductId { get; set; }
    private bool selected;

    public List<SelectedMedia> SelectedMedias { get; set; } = new List<SelectedMedia>();

    public bool Selected
    {
        get { return SelectedMedias.All(x => x.Selected); }
        set
        {
            foreach (var item in SelectedMedias)
            {
                item.Selected = value;
            }
        }
    }

    public bool HasAnySelected => SelectedMedias.Any(x => x.Selected);

    public List<int> SelectedProductMediaIds => SelectedMedias.Where(x => x.Selected).Select(x => x.MediaId).ToList();

    public bool? GetSelectedCol(int colNumber)
    {
        if (colNumber > SelectedMedias.Count - 1)
            return null;

        return SelectedMedias[colNumber].Selected;
    }

    public void SelectCol(int colNumber, bool value)
    {
        if (colNumber > SelectedMedias.Count - 1)
            return;

        SelectedMedias[colNumber].Selected = value;
    }
}