using TMPro;
using UnityEngine;

namespace Notizbuch {
    public class Notebook : MonoBehaviour {
    
        [SerializeField] private string[] pages;
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private GameObject front;
        [SerializeField] private GameObject back;
        [SerializeField] private GameObject background;

        private string[] _activePages;
        private int _currentpage = -1;
        private bool _active;

        private void Start() {
            _activePages = new string[pages.Length];
            _active = false;
            front.SetActive(false);
            back.SetActive(false);
            background.SetActive(false);
            text.text = "";
        }

        private void Update() {
        
            if(Input.GetKeyDown(KeyCode.N)) {
                if (_active) {
                    _active = false;
                    front.SetActive(false);
                    back.SetActive(false);
                    background.SetActive(false);
                    text.text = "";
                }else {
                    _active = true;
                    OpenBook();
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape)) {
                _active = false;
                front.SetActive(false);
                back.SetActive(false);
                background.SetActive(false); 
                text.text = "";
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
                ChangePage(-1);
            if (Input.GetKeyDown(KeyCode.RightArrow))
                ChangePage(1);
        }

        public void ShowPage(int i) {
            if (i > 0 && i < pages.Length) {
                _activePages[i] = pages[i];
            }
        }

        void OpenBook() {
            if (_currentpage == -1) {
                front.SetActive(true);
            }else if (_currentpage == _activePages.Length) {
                back.SetActive(true);
            }else if (_currentpage > 0 && _currentpage < _activePages.Length) {
                background.SetActive(true);
                text.text = _activePages[_currentpage];
            }
        }

        void ChangePage(int i) {
            if (_currentpage + i >= -1 && _currentpage + i <= _activePages.Length) {
                _currentpage += i;

                if (_currentpage == -1) {
                    text.text = "";
                    background.SetActive(false);
                    front.SetActive(true);
                }else if (_currentpage == _activePages.Length) {
                    text.text = "";
                    background.SetActive(false);
                    back.SetActive(true);
                }else {
                    front.SetActive(false);
                    back.SetActive(false);
                    background.SetActive(true);
                    text.text = _activePages[_currentpage];
                }
            }
        }
    }
}