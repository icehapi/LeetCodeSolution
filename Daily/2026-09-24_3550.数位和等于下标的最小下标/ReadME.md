# 3550.数位和等于下标的最小下标

🔗 [题目](https://leetcode.cn/problems/smallest-index-with-digit-sum-equal-to-index/?envType=daily-question&envId=2026-09-24)

## 题目大意

给定一个整数数组 $nums$。寻找满足 $nums[i]$的数位和等于 $i$的最小下标。

## 解题思路

方法：遍历

1. 遍历数组，并计算每个元素的数位和。若等于下标则直接返回即可。遍历完数组都没有找到则返回-1

## 复杂度分析

- 时间复杂度： $O(n)$，其中 $n$ 是数组 $nums$ 的长度。
- 空间复杂度： $O(1)$。
