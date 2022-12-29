/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

// @generated by gentest/gentest.rb from gentest/fixtures/YGFlexDirectionTest.html

test("flex_direction_column_no_height", () => {
  const config = Yoga.Config.create();
  let root;

  config.setExperimentalFeatureEnabled(Yoga.EXPERIMENTAL_FEATURE_ABSOLUTE_PERCENTAGE_AGAINST_PADDING_EDGE, true);

  try {
    root = Yoga.Node.create(config);
    root.setWidth(100);

    const root_child0 = Yoga.Node.create(config);
    root_child0.setHeight(10);
    root.insertChild(root_child0, 0);

    const root_child1 = Yoga.Node.create(config);
    root_child1.setHeight(10);
    root.insertChild(root_child1, 1);

    const root_child2 = Yoga.Node.create(config);
    root_child2.setHeight(10);
    root.insertChild(root_child2, 2);
    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_LTR);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(30);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(100);
    expect(root_child0.getComputedHeight()).toBe(10);

    expect(root_child1.getComputedLeft()).toBe(0);
    expect(root_child1.getComputedTop()).toBe(10);
    expect(root_child1.getComputedWidth()).toBe(100);
    expect(root_child1.getComputedHeight()).toBe(10);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(20);
    expect(root_child2.getComputedWidth()).toBe(100);
    expect(root_child2.getComputedHeight()).toBe(10);

    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_RTL);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(30);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(100);
    expect(root_child0.getComputedHeight()).toBe(10);

    expect(root_child1.getComputedLeft()).toBe(0);
    expect(root_child1.getComputedTop()).toBe(10);
    expect(root_child1.getComputedWidth()).toBe(100);
    expect(root_child1.getComputedHeight()).toBe(10);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(20);
    expect(root_child2.getComputedWidth()).toBe(100);
    expect(root_child2.getComputedHeight()).toBe(10);
  } finally {
    if (typeof root !== "undefined") {
      root.freeRecursive();
    }

    config.free();
  }
});
test("flex_direction_row_no_width", () => {
  const config = Yoga.Config.create();
  let root;

  config.setExperimentalFeatureEnabled(Yoga.EXPERIMENTAL_FEATURE_ABSOLUTE_PERCENTAGE_AGAINST_PADDING_EDGE, true);

  try {
    root = Yoga.Node.create(config);
    root.setFlexDirection(Yoga.FLEX_DIRECTION_ROW);
    root.setHeight(100);

    const root_child0 = Yoga.Node.create(config);
    root_child0.setWidth(10);
    root.insertChild(root_child0, 0);

    const root_child1 = Yoga.Node.create(config);
    root_child1.setWidth(10);
    root.insertChild(root_child1, 1);

    const root_child2 = Yoga.Node.create(config);
    root_child2.setWidth(10);
    root.insertChild(root_child2, 2);
    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_LTR);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(30);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(10);
    expect(root_child0.getComputedHeight()).toBe(100);

    expect(root_child1.getComputedLeft()).toBe(10);
    expect(root_child1.getComputedTop()).toBe(0);
    expect(root_child1.getComputedWidth()).toBe(10);
    expect(root_child1.getComputedHeight()).toBe(100);

    expect(root_child2.getComputedLeft()).toBe(20);
    expect(root_child2.getComputedTop()).toBe(0);
    expect(root_child2.getComputedWidth()).toBe(10);
    expect(root_child2.getComputedHeight()).toBe(100);

    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_RTL);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(30);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(20);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(10);
    expect(root_child0.getComputedHeight()).toBe(100);

    expect(root_child1.getComputedLeft()).toBe(10);
    expect(root_child1.getComputedTop()).toBe(0);
    expect(root_child1.getComputedWidth()).toBe(10);
    expect(root_child1.getComputedHeight()).toBe(100);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(0);
    expect(root_child2.getComputedWidth()).toBe(10);
    expect(root_child2.getComputedHeight()).toBe(100);
  } finally {
    if (typeof root !== "undefined") {
      root.freeRecursive();
    }

    config.free();
  }
});
test("flex_direction_column", () => {
  const config = Yoga.Config.create();
  let root;

  config.setExperimentalFeatureEnabled(Yoga.EXPERIMENTAL_FEATURE_ABSOLUTE_PERCENTAGE_AGAINST_PADDING_EDGE, true);

  try {
    root = Yoga.Node.create(config);
    root.setWidth(100);
    root.setHeight(100);

    const root_child0 = Yoga.Node.create(config);
    root_child0.setHeight(10);
    root.insertChild(root_child0, 0);

    const root_child1 = Yoga.Node.create(config);
    root_child1.setHeight(10);
    root.insertChild(root_child1, 1);

    const root_child2 = Yoga.Node.create(config);
    root_child2.setHeight(10);
    root.insertChild(root_child2, 2);
    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_LTR);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(100);
    expect(root_child0.getComputedHeight()).toBe(10);

    expect(root_child1.getComputedLeft()).toBe(0);
    expect(root_child1.getComputedTop()).toBe(10);
    expect(root_child1.getComputedWidth()).toBe(100);
    expect(root_child1.getComputedHeight()).toBe(10);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(20);
    expect(root_child2.getComputedWidth()).toBe(100);
    expect(root_child2.getComputedHeight()).toBe(10);

    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_RTL);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(100);
    expect(root_child0.getComputedHeight()).toBe(10);

    expect(root_child1.getComputedLeft()).toBe(0);
    expect(root_child1.getComputedTop()).toBe(10);
    expect(root_child1.getComputedWidth()).toBe(100);
    expect(root_child1.getComputedHeight()).toBe(10);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(20);
    expect(root_child2.getComputedWidth()).toBe(100);
    expect(root_child2.getComputedHeight()).toBe(10);
  } finally {
    if (typeof root !== "undefined") {
      root.freeRecursive();
    }

    config.free();
  }
});
test("flex_direction_row", () => {
  const config = Yoga.Config.create();
  let root;

  config.setExperimentalFeatureEnabled(Yoga.EXPERIMENTAL_FEATURE_ABSOLUTE_PERCENTAGE_AGAINST_PADDING_EDGE, true);

  try {
    root = Yoga.Node.create(config);
    root.setFlexDirection(Yoga.FLEX_DIRECTION_ROW);
    root.setWidth(100);
    root.setHeight(100);

    const root_child0 = Yoga.Node.create(config);
    root_child0.setWidth(10);
    root.insertChild(root_child0, 0);

    const root_child1 = Yoga.Node.create(config);
    root_child1.setWidth(10);
    root.insertChild(root_child1, 1);

    const root_child2 = Yoga.Node.create(config);
    root_child2.setWidth(10);
    root.insertChild(root_child2, 2);
    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_LTR);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(10);
    expect(root_child0.getComputedHeight()).toBe(100);

    expect(root_child1.getComputedLeft()).toBe(10);
    expect(root_child1.getComputedTop()).toBe(0);
    expect(root_child1.getComputedWidth()).toBe(10);
    expect(root_child1.getComputedHeight()).toBe(100);

    expect(root_child2.getComputedLeft()).toBe(20);
    expect(root_child2.getComputedTop()).toBe(0);
    expect(root_child2.getComputedWidth()).toBe(10);
    expect(root_child2.getComputedHeight()).toBe(100);

    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_RTL);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(90);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(10);
    expect(root_child0.getComputedHeight()).toBe(100);

    expect(root_child1.getComputedLeft()).toBe(80);
    expect(root_child1.getComputedTop()).toBe(0);
    expect(root_child1.getComputedWidth()).toBe(10);
    expect(root_child1.getComputedHeight()).toBe(100);

    expect(root_child2.getComputedLeft()).toBe(70);
    expect(root_child2.getComputedTop()).toBe(0);
    expect(root_child2.getComputedWidth()).toBe(10);
    expect(root_child2.getComputedHeight()).toBe(100);
  } finally {
    if (typeof root !== "undefined") {
      root.freeRecursive();
    }

    config.free();
  }
});
test("flex_direction_column_reverse", () => {
  const config = Yoga.Config.create();
  let root;

  config.setExperimentalFeatureEnabled(Yoga.EXPERIMENTAL_FEATURE_ABSOLUTE_PERCENTAGE_AGAINST_PADDING_EDGE, true);

  try {
    root = Yoga.Node.create(config);
    root.setFlexDirection(Yoga.FLEX_DIRECTION_COLUMN_REVERSE);
    root.setWidth(100);
    root.setHeight(100);

    const root_child0 = Yoga.Node.create(config);
    root_child0.setHeight(10);
    root.insertChild(root_child0, 0);

    const root_child1 = Yoga.Node.create(config);
    root_child1.setHeight(10);
    root.insertChild(root_child1, 1);

    const root_child2 = Yoga.Node.create(config);
    root_child2.setHeight(10);
    root.insertChild(root_child2, 2);
    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_LTR);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(90);
    expect(root_child0.getComputedWidth()).toBe(100);
    expect(root_child0.getComputedHeight()).toBe(10);

    expect(root_child1.getComputedLeft()).toBe(0);
    expect(root_child1.getComputedTop()).toBe(80);
    expect(root_child1.getComputedWidth()).toBe(100);
    expect(root_child1.getComputedHeight()).toBe(10);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(70);
    expect(root_child2.getComputedWidth()).toBe(100);
    expect(root_child2.getComputedHeight()).toBe(10);

    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_RTL);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(90);
    expect(root_child0.getComputedWidth()).toBe(100);
    expect(root_child0.getComputedHeight()).toBe(10);

    expect(root_child1.getComputedLeft()).toBe(0);
    expect(root_child1.getComputedTop()).toBe(80);
    expect(root_child1.getComputedWidth()).toBe(100);
    expect(root_child1.getComputedHeight()).toBe(10);

    expect(root_child2.getComputedLeft()).toBe(0);
    expect(root_child2.getComputedTop()).toBe(70);
    expect(root_child2.getComputedWidth()).toBe(100);
    expect(root_child2.getComputedHeight()).toBe(10);
  } finally {
    if (typeof root !== "undefined") {
      root.freeRecursive();
    }

    config.free();
  }
});
test("flex_direction_row_reverse", () => {
  const config = Yoga.Config.create();
  let root;

  config.setExperimentalFeatureEnabled(Yoga.EXPERIMENTAL_FEATURE_ABSOLUTE_PERCENTAGE_AGAINST_PADDING_EDGE, true);

  try {
    root = Yoga.Node.create(config);
    root.setFlexDirection(Yoga.FLEX_DIRECTION_ROW_REVERSE);
    root.setWidth(100);
    root.setHeight(100);

    const root_child0 = Yoga.Node.create(config);
    root_child0.setWidth(10);
    root.insertChild(root_child0, 0);

    const root_child1 = Yoga.Node.create(config);
    root_child1.setWidth(10);
    root.insertChild(root_child1, 1);

    const root_child2 = Yoga.Node.create(config);
    root_child2.setWidth(10);
    root.insertChild(root_child2, 2);
    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_LTR);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(90);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(10);
    expect(root_child0.getComputedHeight()).toBe(100);

    expect(root_child1.getComputedLeft()).toBe(80);
    expect(root_child1.getComputedTop()).toBe(0);
    expect(root_child1.getComputedWidth()).toBe(10);
    expect(root_child1.getComputedHeight()).toBe(100);

    expect(root_child2.getComputedLeft()).toBe(70);
    expect(root_child2.getComputedTop()).toBe(0);
    expect(root_child2.getComputedWidth()).toBe(10);
    expect(root_child2.getComputedHeight()).toBe(100);

    root.calculateLayout(Yoga.UNDEFINED, Yoga.UNDEFINED, Yoga.DIRECTION_RTL);

    expect(root.getComputedLeft()).toBe(0);
    expect(root.getComputedTop()).toBe(0);
    expect(root.getComputedWidth()).toBe(100);
    expect(root.getComputedHeight()).toBe(100);

    expect(root_child0.getComputedLeft()).toBe(0);
    expect(root_child0.getComputedTop()).toBe(0);
    expect(root_child0.getComputedWidth()).toBe(10);
    expect(root_child0.getComputedHeight()).toBe(100);

    expect(root_child1.getComputedLeft()).toBe(10);
    expect(root_child1.getComputedTop()).toBe(0);
    expect(root_child1.getComputedWidth()).toBe(10);
    expect(root_child1.getComputedHeight()).toBe(100);

    expect(root_child2.getComputedLeft()).toBe(20);
    expect(root_child2.getComputedTop()).toBe(0);
    expect(root_child2.getComputedWidth()).toBe(10);
    expect(root_child2.getComputedHeight()).toBe(100);
  } finally {
    if (typeof root !== "undefined") {
      root.freeRecursive();
    }

    config.free();
  }
});
