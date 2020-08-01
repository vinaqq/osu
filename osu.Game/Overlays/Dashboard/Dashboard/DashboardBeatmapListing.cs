﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Beatmaps;
using osuTK;

namespace osu.Game.Overlays.Dashboard.Dashboard
{
    public class DashboardBeatmapListing : CompositeDrawable
    {
        private readonly List<BeatmapSetInfo> newBeatmaps;
        private readonly List<BeatmapSetInfo> popularBeatmaps;

        public DashboardBeatmapListing(List<BeatmapSetInfo> newBeatmaps, List<BeatmapSetInfo> popularBeatmaps)
        {
            this.newBeatmaps = newBeatmaps;
            this.popularBeatmaps = popularBeatmaps;
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            RelativeSizeAxes = Axes.X;
            AutoSizeAxes = Axes.Y;
            InternalChild = new FillFlowContainer<DrawableBeatmapsList>
            {
                RelativeSizeAxes = Axes.X,
                AutoSizeAxes = Axes.Y,
                Direction = FillDirection.Vertical,
                Spacing = new Vector2(0, 10),
                Children = new DrawableBeatmapsList[]
                {
                    new DrawableNewBeatmapsList(newBeatmaps),
                    new DrawablePopularBeatmapsList(popularBeatmaps)
                }
            };
        }
    }
}
