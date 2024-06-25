/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 *
 * @generated SignedSource<<6116c0f130b77b635a6551b3204c3cf8>>
 * generated by gentest/gentest-driver.ts from gentest/fixtures/YGPaddingTest.html
 */

package com.facebook.yoga;

import static org.junit.Assert.assertEquals;

import org.junit.Ignore;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;
import com.facebook.yoga.utils.TestUtils;

@RunWith(Parameterized.class)
public class YGPaddingTest {
  @Parameterized.Parameters(name = "{0}")
  public static Iterable<TestParametrization.NodeFactory> nodeFactories() {
    return TestParametrization.nodeFactories();
  }

  @Parameterized.Parameter public TestParametrization.NodeFactory mNodeFactory;

  @Test
  public void test_padding_no_size() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setPadding(YogaEdge.LEFT, 10);
    root.setPadding(YogaEdge.TOP, 10);
    root.setPadding(YogaEdge.RIGHT, 10);
    root.setPadding(YogaEdge.BOTTOM, 10);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(20f, root.getLayoutWidth(), 0.0f);
    assertEquals(20f, root.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(20f, root.getLayoutWidth(), 0.0f);
    assertEquals(20f, root.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_padding_container_match_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setPadding(YogaEdge.LEFT, 10);
    root.setPadding(YogaEdge.TOP, 10);
    root.setPadding(YogaEdge.RIGHT, 10);
    root.setPadding(YogaEdge.BOTTOM, 10);

    final YogaNode root_child0 = createNode(config);
    root_child0.setWidth(10f);
    root_child0.setHeight(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(30f, root.getLayoutWidth(), 0.0f);
    assertEquals(30f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(30f, root.getLayoutWidth(), 0.0f);
    assertEquals(30f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_padding_flex_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setPadding(YogaEdge.LEFT, 10);
    root.setPadding(YogaEdge.TOP, 10);
    root.setPadding(YogaEdge.RIGHT, 10);
    root.setPadding(YogaEdge.BOTTOM, 10);
    root.setWidth(100f);
    root.setHeight(100f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setFlexGrow(1f);
    root_child0.setWidth(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(80f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(80f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(80f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_padding_stretch_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setPadding(YogaEdge.LEFT, 10);
    root.setPadding(YogaEdge.TOP, 10);
    root.setPadding(YogaEdge.RIGHT, 10);
    root.setPadding(YogaEdge.BOTTOM, 10);
    root.setWidth(100f);
    root.setHeight(100f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setHeight(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(80f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(10f, root_child0.getLayoutX(), 0.0f);
    assertEquals(10f, root_child0.getLayoutY(), 0.0f);
    assertEquals(80f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_padding_center_child() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setJustifyContent(YogaJustify.CENTER);
    root.setAlignItems(YogaAlign.CENTER);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setPadding(YogaEdge.START, 10);
    root.setPadding(YogaEdge.END, 20);
    root.setPadding(YogaEdge.BOTTOM, 20);
    root.setWidth(100f);
    root.setHeight(100f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setWidth(10f);
    root_child0.setHeight(10f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(40f, root_child0.getLayoutX(), 0.0f);
    assertEquals(35f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(100f, root.getLayoutWidth(), 0.0f);
    assertEquals(100f, root.getLayoutHeight(), 0.0f);

    assertEquals(50f, root_child0.getLayoutX(), 0.0f);
    assertEquals(35f, root_child0.getLayoutY(), 0.0f);
    assertEquals(10f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(10f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_child_with_padding_align_end() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setJustifyContent(YogaJustify.FLEX_END);
    root.setAlignItems(YogaAlign.FLEX_END);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setWidth(200f);
    root.setHeight(200f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setPadding(YogaEdge.LEFT, 20);
    root_child0.setPadding(YogaEdge.TOP, 20);
    root_child0.setPadding(YogaEdge.RIGHT, 20);
    root_child0.setPadding(YogaEdge.BOTTOM, 20);
    root_child0.setWidth(100f);
    root_child0.setHeight(100f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(200f, root.getLayoutWidth(), 0.0f);
    assertEquals(200f, root.getLayoutHeight(), 0.0f);

    assertEquals(100f, root_child0.getLayoutX(), 0.0f);
    assertEquals(100f, root_child0.getLayoutY(), 0.0f);
    assertEquals(100f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(100f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(200f, root.getLayoutWidth(), 0.0f);
    assertEquals(200f, root.getLayoutHeight(), 0.0f);

    assertEquals(0f, root_child0.getLayoutX(), 0.0f);
    assertEquals(100f, root_child0.getLayoutY(), 0.0f);
    assertEquals(100f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(100f, root_child0.getLayoutHeight(), 0.0f);
  }

  @Test
  public void test_physical_and_relative_edge_defined() {
    YogaConfig config = YogaConfigFactory.create();

    final YogaNode root = createNode(config);
    root.setPositionType(YogaPositionType.ABSOLUTE);
    root.setPadding(YogaEdge.LEFT, 20);
    root.setPadding(YogaEdge.END, 50);
    root.setWidth(200f);
    root.setHeight(200f);

    final YogaNode root_child0 = createNode(config);
    root_child0.setWidthPercent(100f);
    root_child0.setHeight(50f);
    root.addChildAt(root_child0, 0);
    root.setDirection(YogaDirection.LTR);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(200f, root.getLayoutWidth(), 0.0f);
    assertEquals(200f, root.getLayoutHeight(), 0.0f);

    assertEquals(20f, root_child0.getLayoutX(), 0.0f);
    assertEquals(0f, root_child0.getLayoutY(), 0.0f);
    assertEquals(130f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(50f, root_child0.getLayoutHeight(), 0.0f);

    root.setDirection(YogaDirection.RTL);
    root.calculateLayout(YogaConstants.UNDEFINED, YogaConstants.UNDEFINED);

    assertEquals(0f, root.getLayoutX(), 0.0f);
    assertEquals(0f, root.getLayoutY(), 0.0f);
    assertEquals(200f, root.getLayoutWidth(), 0.0f);
    assertEquals(200f, root.getLayoutHeight(), 0.0f);

    assertEquals(50f, root_child0.getLayoutX(), 0.0f);
    assertEquals(0f, root_child0.getLayoutY(), 0.0f);
    assertEquals(150f, root_child0.getLayoutWidth(), 0.0f);
    assertEquals(50f, root_child0.getLayoutHeight(), 0.0f);
  }

  private YogaNode createNode(YogaConfig config) {
    return mNodeFactory.create(config);
  }
}
