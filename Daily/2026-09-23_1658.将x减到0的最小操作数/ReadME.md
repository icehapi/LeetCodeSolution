# 1658.将x减到0的最小操作数

🔗 [题目](https://leetcode.cn/problems/minimum-operations-to-reduce-x-to-zero/?envType=daily-question&envId=2026-09-23)

## 题目大意

给定一个整数数组 $nums$ 和一个整数 $x$，每次可以从数组的左侧或者右侧取出一个数，使得这些数之和等于x，返回最小的取出个数。无法满足则返回 -1。

由于取数是从数组左侧或者右侧取出，那么数组中间的元素一定是一个连续的子数组，题目求解可以转变为找到最长子数组$t$，使得$sum(nums) - sum(t) = x$。

## 解题思路

方法：滑动窗口

1. 构造一个滑动窗口$t$，滑动窗口左侧的元素和为$leftSum=0$、右侧的元素和为$rightSum=sum(nums)$。窗口边界初始值$left=-1$，$right=0$。

2. 对于滑动窗口的移动：
    1. 若$leftSum + rightSum==x$时，为一组答案，对应的操作数为$(left + 1) +(n - right)$。
    2. 若$leftSum + rightSum>x$时，和大了，则窗口右移，即$rightSum-=nums[right++]$。
    3. 若$leftSum + rightSum<x$时，和小了，则窗口左移，即$leftSum+=nums[left++]$

## 复杂度分析

- 时间复杂度：$O(n)$，其中 $n$ 是数组 $nums$*的长度。$left$和$right$最多遍历一次数组。
- 空间复杂度：$O(1)$。
