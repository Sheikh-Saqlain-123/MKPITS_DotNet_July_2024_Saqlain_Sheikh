//Method 3: (By Obfuscation using Token Pasting)
#define pseudo(s, t, u, m, p, e, d) m##s##u##t
#define nomain pseudo(a, n, i, m, a, t, e)
 
int nomain(void)
{
    printf("Hello World\n");
    return 0;
}