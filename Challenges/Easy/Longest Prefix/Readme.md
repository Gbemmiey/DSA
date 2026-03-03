## Longest Common Prefix

Write a function to find the **longest common prefix** string amongst an array of strings.

If there is no common prefix, return an empty string `""`.

---

### Example 1

**Input:**

```text
strs = ["flower","flow","flight"]
```

**Output:**

```text
"fl"
```

---

### Example 2

**Input:**

```text
strs = ["dog","racecar","car"]
```

**Output:**

```text
""
```

**Explanation:**

There is no common prefix among the input strings.

---

### Constraints

* `1 <= strs.length <= 200`
* `0 <= strs[i].length <= 200`
* `strs[i]` consists of only lowercase English letters if it is non-empty.
