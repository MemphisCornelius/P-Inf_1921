using UnityEngine;
		
class Notebok : MonoBehaviour{
    [SerializeField] Page[] pages;
    public int currentPage = 0;
    public GameObject emptyPage;
    public bool active;
	
    private void Start(){
				
    }
    
    private void Update(){
        if(Input.GetKeyDown(KeyCode.N)) {
            if(!active) {
                OpenBook();
            }else {
                CloseBook();
            }
        }
		 
        if (active) {
            if(Input.GetKeyDown(KeyCode.RightArrow)) {
                ChangePage(1);
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow)) {
                ChangePage(-1);
            }
            if (Input.GetKeyDown(KeyCode.Escape)) {
                CloseBook();
            }
        }
		
    }
		
    private void OpenBook() {
        if (pages[currentPage].found)
        {
            Debug.Log("if");
            pages[currentPage].sprite.SetActive(true);
        }
        else
        {
            Debug.Log("else");
            emptyPage.SetActive(true);
        }

        active = true;
    }

    private void CloseBook() {
        pages[currentPage].sprite.SetActive(false);
        emptyPage.SetActive(false);
        active = false;
    }

    public void ChangePage(int i) {
        if ((currentPage + i)>= pages.Length) {
            pages[currentPage].sprite.SetActive(false);
            emptyPage.SetActive(false);
            if (pages[0].found)
            {
                
                pages[0].sprite.SetActive(true);
            }
            else
            {
                
                emptyPage.SetActive(true);
            }

            currentPage = 0;

        }else if ((currentPage + i) < 0) {
            pages[currentPage].sprite.SetActive(false);
            emptyPage.SetActive(false);
            if (pages[pages.Length-1].found)
            {
                
                pages[pages.Length -1].sprite.SetActive(true);
            }
            else
            {
                
                emptyPage.SetActive(true);
            }

            currentPage = pages.Length - 1;

        }else {
            pages[currentPage].sprite.SetActive(false);
            emptyPage.SetActive(false);
            if (pages[currentPage+i].found)
            {
                
                pages[currentPage+i].sprite.SetActive(true);
            }
            else
            {
                
                emptyPage.SetActive(true);
            }

            currentPage += i;
        }
    }
}