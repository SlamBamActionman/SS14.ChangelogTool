namespace SS14.ChangelogTool.Models.GitHub;

/// <summary> Container for labels nodes. </summary>
public sealed record GitHubLabels(List<GitHubLabelNode> Nodes)
{
    public static GitHubLabels From(string labelName) => new([new GitHubLabelNode(labelName)]);
}

public sealed record GitHubLabelNode(string Name);