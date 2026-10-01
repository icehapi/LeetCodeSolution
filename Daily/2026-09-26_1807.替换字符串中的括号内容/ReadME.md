# 1807.替换字符串中的括号内容

🔗 [题目](https://leetcode.cn/problems/evaluate-the-bracket-pairs-of-a-string/description/?envType=daily-question&envId=2026-09-26)

## 题目大意

将字符串 `s`中括号的内容替换成 `knowledge`中对应的内容，如果没有则替换成 `?`

## 解题思路

方法：哈希表

1. 将 `knowledge`数组转换为哈希表。
2. 遍历 `s`，遇到 `(`就开始读取到 `)`之前的字符串，然后在哈希表中寻找对应的内容进行替换，没有则替换成 `?`

## 复杂度分析

- 时间复杂度： $O(n + k)$，其中 $n$ 是字符串 $s$ 的长度，$k$ 是字符串数组 $knowledge$ 中所有字符串的长度之和。
- 空间复杂度： $O(n + k)$，其中 $n$ 是字符串 $s$ 的长度，$k$ 是字符串数组 $knowledge$ 中所有字符串的长度之和。保存哈希表 $dict$ 和 $key$ 分别需要 $O(k)$ 和 $O(n)$。
