/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

// @generated by gentest/gentest.rb from gentest/fixtures/YGAndroidNewsFeed.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAndroidNewsFeed
    {
        [Test]
        public void Test_android_news_feed()
        {
            YogaConfig config = new YogaConfig();
            config.SetExperimentalFeatureEnabled(YogaExperimentalFeature.AbsolutePercentageAgainstPaddingEdge, true);

            YogaNode root = new YogaNode(config);
            root.AlignContent = YogaAlign.Stretch;
            root.Width = 1080;

            YogaNode root_child0 = new YogaNode(config);
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode(config);
            root_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0.Insert(0, root_child0_child0);

            YogaNode root_child0_child0_child0 = new YogaNode(config);
            root_child0_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0.Insert(0, root_child0_child0_child0);

            YogaNode root_child0_child0_child0_child0 = new YogaNode(config);
            root_child0_child0_child0_child0.FlexDirection = YogaFlexDirection.Row;
            root_child0_child0_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child0_child0.AlignItems = YogaAlign.FlexStart;
            root_child0_child0_child0_child0.MarginStart = 36;
            root_child0_child0_child0_child0.MarginTop = 24;
            root_child0_child0_child0.Insert(0, root_child0_child0_child0_child0);

            YogaNode root_child0_child0_child0_child0_child0 = new YogaNode(config);
            root_child0_child0_child0_child0_child0.FlexDirection = YogaFlexDirection.Row;
            root_child0_child0_child0_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child0_child0.Insert(0, root_child0_child0_child0_child0_child0);

            YogaNode root_child0_child0_child0_child0_child0_child0 = new YogaNode(config);
            root_child0_child0_child0_child0_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child0_child0_child0_child0.Width = 120;
            root_child0_child0_child0_child0_child0_child0.Height = 120;
            root_child0_child0_child0_child0_child0.Insert(0, root_child0_child0_child0_child0_child0_child0);

            YogaNode root_child0_child0_child0_child0_child1 = new YogaNode(config);
            root_child0_child0_child0_child0_child1.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child0_child0_child1.FlexShrink = 1;
            root_child0_child0_child0_child0_child1.MarginRight = 36;
            root_child0_child0_child0_child0_child1.PaddingLeft = 36;
            root_child0_child0_child0_child0_child1.PaddingTop = 21;
            root_child0_child0_child0_child0_child1.PaddingRight = 36;
            root_child0_child0_child0_child0_child1.PaddingBottom = 18;
            root_child0_child0_child0_child0.Insert(1, root_child0_child0_child0_child0_child1);

            YogaNode root_child0_child0_child0_child0_child1_child0 = new YogaNode(config);
            root_child0_child0_child0_child0_child1_child0.FlexDirection = YogaFlexDirection.Row;
            root_child0_child0_child0_child0_child1_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child0_child0_child1_child0.FlexShrink = 1;
            root_child0_child0_child0_child0_child1.Insert(0, root_child0_child0_child0_child0_child1_child0);

            YogaNode root_child0_child0_child0_child0_child1_child1 = new YogaNode(config);
            root_child0_child0_child0_child0_child1_child1.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child0_child0_child1_child1.FlexShrink = 1;
            root_child0_child0_child0_child0_child1.Insert(1, root_child0_child0_child0_child0_child1_child1);

            YogaNode root_child0_child0_child1 = new YogaNode(config);
            root_child0_child0_child1.AlignContent = YogaAlign.Stretch;
            root_child0_child0.Insert(1, root_child0_child0_child1);

            YogaNode root_child0_child0_child1_child0 = new YogaNode(config);
            root_child0_child0_child1_child0.FlexDirection = YogaFlexDirection.Row;
            root_child0_child0_child1_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child1_child0.AlignItems = YogaAlign.FlexStart;
            root_child0_child0_child1_child0.MarginStart = 174;
            root_child0_child0_child1_child0.MarginTop = 24;
            root_child0_child0_child1.Insert(0, root_child0_child0_child1_child0);

            YogaNode root_child0_child0_child1_child0_child0 = new YogaNode(config);
            root_child0_child0_child1_child0_child0.FlexDirection = YogaFlexDirection.Row;
            root_child0_child0_child1_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child1_child0.Insert(0, root_child0_child0_child1_child0_child0);

            YogaNode root_child0_child0_child1_child0_child0_child0 = new YogaNode(config);
            root_child0_child0_child1_child0_child0_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child1_child0_child0_child0.Width = 72;
            root_child0_child0_child1_child0_child0_child0.Height = 72;
            root_child0_child0_child1_child0_child0.Insert(0, root_child0_child0_child1_child0_child0_child0);

            YogaNode root_child0_child0_child1_child0_child1 = new YogaNode(config);
            root_child0_child0_child1_child0_child1.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child1_child0_child1.FlexShrink = 1;
            root_child0_child0_child1_child0_child1.MarginRight = 36;
            root_child0_child0_child1_child0_child1.PaddingLeft = 36;
            root_child0_child0_child1_child0_child1.PaddingTop = 21;
            root_child0_child0_child1_child0_child1.PaddingRight = 36;
            root_child0_child0_child1_child0_child1.PaddingBottom = 18;
            root_child0_child0_child1_child0.Insert(1, root_child0_child0_child1_child0_child1);

            YogaNode root_child0_child0_child1_child0_child1_child0 = new YogaNode(config);
            root_child0_child0_child1_child0_child1_child0.FlexDirection = YogaFlexDirection.Row;
            root_child0_child0_child1_child0_child1_child0.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child1_child0_child1_child0.FlexShrink = 1;
            root_child0_child0_child1_child0_child1.Insert(0, root_child0_child0_child1_child0_child1_child0);

            YogaNode root_child0_child0_child1_child0_child1_child1 = new YogaNode(config);
            root_child0_child0_child1_child0_child1_child1.AlignContent = YogaAlign.Stretch;
            root_child0_child0_child1_child0_child1_child1.FlexShrink = 1;
            root_child0_child0_child1_child0_child1.Insert(1, root_child0_child0_child1_child0_child1_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(1080f, root.LayoutWidth);
            Assert.AreEqual(240f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(1080f, root_child0.LayoutWidth);
            Assert.AreEqual(240f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(1080f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(240f, root_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0.LayoutY);
            Assert.AreEqual(1080f, root_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(144f, root_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child0_child0.LayoutX);
            Assert.AreEqual(24f, root_child0_child0_child0_child0.LayoutY);
            Assert.AreEqual(1044f, root_child0_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(120f, root_child0_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0.LayoutY);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0_child0.LayoutY);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(120f, root_child0_child0_child0_child0_child1.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child0_child0_child1.LayoutWidth);
            Assert.AreEqual(39f, root_child0_child0_child0_child0_child1.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child0_child0_child1_child0.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child0_child0_child1_child0.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child0.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child0_child0_child1_child1.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child0_child0_child1_child1.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child1.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child1.LayoutX);
            Assert.AreEqual(144f, root_child0_child0_child1.LayoutY);
            Assert.AreEqual(1080f, root_child0_child0_child1.LayoutWidth);
            Assert.AreEqual(96f, root_child0_child0_child1.LayoutHeight);

            Assert.AreEqual(174f, root_child0_child0_child1_child0.LayoutX);
            Assert.AreEqual(24f, root_child0_child0_child1_child0.LayoutY);
            Assert.AreEqual(906f, root_child0_child0_child1_child0.LayoutWidth);
            Assert.AreEqual(72f, root_child0_child0_child1_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0.LayoutWidth);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0_child0.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(72f, root_child0_child0_child1_child0_child1.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child1.LayoutWidth);
            Assert.AreEqual(39f, root_child0_child0_child1_child0_child1.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child1_child0_child1_child0.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child1_child0_child1_child0.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child0.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child1_child0_child1_child1.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child1_child0_child1_child1.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child1.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(1080f, root.LayoutWidth);
            Assert.AreEqual(240f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(1080f, root_child0.LayoutWidth);
            Assert.AreEqual(240f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(1080f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(240f, root_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0.LayoutY);
            Assert.AreEqual(1080f, root_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(144f, root_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child0_child0.LayoutX);
            Assert.AreEqual(24f, root_child0_child0_child0_child0.LayoutY);
            Assert.AreEqual(1044f, root_child0_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(120f, root_child0_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(924f, root_child0_child0_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0.LayoutY);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child0_child0.LayoutY);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(120f, root_child0_child0_child0_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(816f, root_child0_child0_child0_child0_child1.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child0_child0_child1.LayoutWidth);
            Assert.AreEqual(39f, root_child0_child0_child0_child0_child1.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child0_child0_child1_child0.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child0_child0_child1_child0.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child0.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child0_child0_child1_child1.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child0_child0_child1_child1.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child1.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child0_child0_child1_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child1.LayoutX);
            Assert.AreEqual(144f, root_child0_child0_child1.LayoutY);
            Assert.AreEqual(1080f, root_child0_child0_child1.LayoutWidth);
            Assert.AreEqual(96f, root_child0_child0_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child1_child0.LayoutX);
            Assert.AreEqual(24f, root_child0_child0_child1_child0.LayoutY);
            Assert.AreEqual(906f, root_child0_child0_child1_child0.LayoutWidth);
            Assert.AreEqual(72f, root_child0_child0_child1_child0.LayoutHeight);

            Assert.AreEqual(834f, root_child0_child0_child1_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0.LayoutWidth);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child0_child0.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0_child0.LayoutWidth);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child0_child0.LayoutHeight);

            Assert.AreEqual(726f, root_child0_child0_child1_child0_child1.LayoutX);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1.LayoutY);
            Assert.AreEqual(72f, root_child0_child0_child1_child0_child1.LayoutWidth);
            Assert.AreEqual(39f, root_child0_child0_child1_child0_child1.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child1_child0_child1_child0.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child1_child0_child1_child0.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child0.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child0.LayoutHeight);

            Assert.AreEqual(36f, root_child0_child0_child1_child0_child1_child1.LayoutX);
            Assert.AreEqual(21f, root_child0_child0_child1_child0_child1_child1.LayoutY);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child1.LayoutWidth);
            Assert.AreEqual(0f, root_child0_child0_child1_child0_child1_child1.LayoutHeight);
        }

    }
}
