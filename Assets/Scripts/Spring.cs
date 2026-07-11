using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Sprite _sprung;
    AudioSource _audioSource;
    SpriteRenderer _spriteRenderer;
    Sprite _defaultSprite;

    // Called when the script instance is being loaded.
    // Caches the SpriteRenderer reference and the initial/default sprite.
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultSprite = _spriteRenderer.sprite;
    }

    // Called by Unity when another Collider2D enters this object's Collider2D.
    // If the collider belongs to the player, restore the default (un-sprung) sprite.
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            _spriteRenderer.sprite = _sprung;
            _audioSource.Play();
        }
            
    }

    // Called by Unity when another Collider2D exits this object's Collider2D.
    // If the collider belongs to the player, set the sprite to the "sprung" variant.
   void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
            _spriteRenderer.sprite = _sprung;
    }
}
